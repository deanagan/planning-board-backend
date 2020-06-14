from flask import Flask

app = Flask(__name__)


@app.route('/')
def home():
    return "I want to be something useful when I grow up"


app.run(port=4999)
