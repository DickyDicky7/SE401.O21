package com.example;

import com.example.levelfactory.LevelFactory;
import com.example.levelfactory.LevelFinalFactory;
import com.example.levelfactory.LevelOneFactory;
import com.example.levelfactory.LevelTwoFactory;


public class Client {
    public static void main(String[] args) {
        System.out.println("\nStarting game with level 1");
        LevelFactory levelOneFactory = new LevelOneFactory();
        levelOneFactory.beginLevel();

        System.out.println("\nStarting game with level 2");
        LevelFactory levelTwoFactory = new LevelTwoFactory();
        levelTwoFactory.beginLevel();

        System.out.println("\nStarting game with final level");
        LevelFactory levelFinalFactory = new LevelFinalFactory();
        levelFinalFactory.beginLevel();
    }

}












