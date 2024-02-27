package com.example.levelfactory;

import com.example.object.Object;
import com.example.object.ObjectTypes;
import com.example.object.Asteroid;
import com.example.object.PowerUp;

public class LevelTwoFactory extends LevelFactory {
    public LevelTwoFactory() {
        randomThreshold = 0.8F;
        objectCount = 20;
    }

    @Override
    public Object createObject() {
        ObjectTypes type = Math.random() > randomThreshold ?
                ObjectTypes.POWER_UP:ObjectTypes.ASTEROID;
        switch (type) {
            case POWER_UP:
                return new PowerUp(20, 30);
            case ASTEROID:
                return new Asteroid(5, 50, 50);
            default:
                return null;
        }
    }
}