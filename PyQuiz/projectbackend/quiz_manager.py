import json
import uuid
import os

class QuizManager:
    def __init__(self, questions_file):
        base_dir = os.path.dirname(__file__)
        file_path = os.path.join(base_dir, questions_file)

        with open(file_path, "r") as f:
            self.questions = json.load(f)

        self.sessions = {}

    def start_quiz(self):
        session_id = str(uuid.uuid4())
        self.sessions[session_id] = {"index": 0, "score": 0}
        return session_id, self.questions[0]

    def get_question(self, session_id):
        session = self.sessions.get(session_id)
        if not session:
            return None
        idx = session["index"]
        if idx >= len(self.questions):
            return None
        return self.questions[idx]

    def answer_question(self, session_id, answer):
        session = self.sessions.get(session_id)
        if not session:
            return None

        idx = session["index"]
        correct = (self.questions[idx]["answer"].lower() == answer.lower())
        if correct:
            session["score"] += 1

        session["index"] += 1

        next_question = None
        if session["index"] < len(self.questions):
            next_question = self.questions[session["index"]]

        return correct, next_question

    def get_score(self, session_id):
        session = self.sessions.get(session_id)
        if not session:
            return None
        return session["score"]
