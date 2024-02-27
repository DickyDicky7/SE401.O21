package com.example.object;


public class Asteroid extends Object {
    public int damage;
    public float size;

    public Asteroid(int damage, float size, float speed) {
        this.damage = damage;
        this.size = size;
        this.speed = speed;
    }

    public void move() {
        System.out.println("Asteroid is moving at speed: " + speed);
    }
}