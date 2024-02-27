package com.example.object;

public class PowerUp extends Object {
    public int duration;

    public PowerUp(int duration, float speed) {
        this.duration = duration;
        this.speed = speed;
    }

    public void move() {
        System.out.println("PowerUp is moving at speed: " + speed);
    }
}