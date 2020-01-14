from django.shortcuts import render
import random

# Create your views here.
from django.shortcuts import render, redirect


def index(request):
    if "gold_amount" not in request.session:
        request.session["gold_amount"] = 0
    return render(request, 'index.html')


def process_money(request):
    total = request.session["gold_amount"]
    if request.POST["location"] == "Farm":
        Random_Numbers = random.randint(10, 20)
        total += Random_Numbers
        request.session["gold_amount"] = total
        return redirect("/")
    if request.POST["location"] == "Cave":
        Random_Numbers = random.randint(5, 10)
        total += Random_Numbers
        request.session["gold_amount"] = total
        return redirect("/")
    if request.POST["location"] == "House":
        Random_Numbers = random.randint(2, 5)
        total += Random_Numbers
        request.session["gold_amount"] = total
        return redirect("/")
    if request.POST["location"] == "Casino":
        Random_Numbers = random.randint(-50, 50)
        total += Random_Numbers
        request.session["gold_amount"] = total
        return redirect("/")
