pip install flask flask-cors
from flask import Flask, request, jsonify
from flask_cors import CORS
from quiz_manager import QuizManager

app = Flask(__name__)
CORS(app)

quiz = QuizManager("questions.json")


@app.post("/start")
def start():
    session_id, first_q = quiz.start_quiz()
    return jsonify({
        "session_id": session_id,
        "question": {
            "id": first_q["id"],
            "text": first_q["text"],
            "options": first_q["options"]
        }
    })


@app.get("/question")
def get_question():
    session_id = request.args.get("session_id")
    q = quiz.get_question(session_id)
    if not q:
        return jsonify({"error": "invalid session or no more questions"}), 400

    return jsonify({
        "question": {
            "id": q["id"],
            "text": q["text"],
            "options": q["options"]
        }
    })


@app.post("/answer")
def answer():
    data = request.json
    session_id = data.get("session_id")
    user_answer = data.get("answer")

    result = quiz.answer_question(session_id, user_answer)
    if result is None:
        return jsonify({"error": "invalid session"}), 400

    correct, next_q = result
    response = {"correct": correct}

    if next_q:
        response["next_question"] = {
            "id": next_q["id"],
            "text": next_q["text"],
            "options": next_q["options"]
        }
    else:
        response["message"] = "quiz complete"

    return jsonify(response)


@app.get("/score")
def score():
    session_id = request.args.get("session_id")
    s = quiz.get_score(session_id)
    if s is None:
        return jsonify({"error": "invalid session"}), 400
    return jsonify({"score": s})


if __name__ == "__main__":
    app.run(debug=True)
