from flask import Flask, render_template
import random

app = Flask(__name__)


@app.route("/")
def index():
    return "Welcome!"


@app.route("/play")
def new_page():
    return render_template("playground.html")


@app.route("/dojo")
def new_page():
    return render_template("index.html")


@app.route("/repeat/<num>/<string_1>")
def statement_presented(num, string_1):
    multi = (string_1)*int(num)
    return render_template("pattern.html", multi=multi, num=int(num))


@app.route("/say/<name>")
def new_guest(name):
    cube1 = random.randint(1, 6)
    cube2 = random.randint(1, 6)
    return render_template("guests.html", guest_from_url=name, cube1=cube1, cube2=cube2)


if __name__ == "__main__":
    app.run(debug=True)
