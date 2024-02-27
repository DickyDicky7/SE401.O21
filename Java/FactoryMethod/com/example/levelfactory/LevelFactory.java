package com.example.levelfactory;

import com.example.object.Object;

public abstract class LevelFactory {
    protected int objectCount;
    protected float randomThreshold;

    public void beginLevel() {
        for (int i = 0; i < objectCount; i++) {
            Object object = createObject();
            object.move();
        }
    }

    protected abstract Object createObject();
}