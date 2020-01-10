from flask import Flask, render_template

app = Flask(__name__)


@app.route("/")
def index():
    return "Welcome!"


@app.route("/play/<x>/<box_color>")
def new_page(x, box_color):
    context = {
        "box_color": box_color,
        "num": int(x)
    }
    return render_template("play.html", context=context)


if __name__ == "__main__":
    app.run(debug=True)
