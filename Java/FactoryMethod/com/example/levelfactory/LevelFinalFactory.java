package com.example.levelfactory;

import com.example.object.Object;
import com.example.object.Asteroid;

public class LevelFinalFactory extends LevelFactory {
    public LevelFinalFactory() {
        objectCount = 40;
    }

    @Override
    public Object createObject() {
        return new Asteroid(20, 100, 50);
    }
}
