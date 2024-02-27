package com.example.levelfactory;

import com.example.object.Object;
import com.example.object.ObjectTypes;
import com.example.object.Asteroid;
import com.example.object.PowerUp;

public class LevelOneFactory extends LevelFactory {
    public LevelOneFactory() {
        objectCount = 10;
        randomThreshold = 0.5F;
    }

    @Override
    public Object createObject() {
        ObjectTypes type = Math.random() > randomThreshold ?
                ObjectTypes.POWER_UP:ObjectTypes.ASTEROID;
        switch (type) {
            case POWER_UP:
                return new PowerUp(30, 20);
            case ASTEROID:
                return new Asteroid(1, 30, 30);
            default:
                return null;
        }
    }
}