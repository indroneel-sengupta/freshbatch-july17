/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package interfaces;

import java.io.*;
import java.util.*;

/**
 *
 * @author Indroneel Sengupta
 */

class Person implements Comparable<Person>{
    String name;
    double ht_in_inches;
    int weight;
    public int compareTo(Person p)
    {
        
        return this.weight - p.weight;
    }
    Person(String name,double ht,int wt){
        this.name = name;
        this.ht_in_inches = ht;
        this.weight = wt;
    }
    
}


public class Interfaces {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        ArrayList<Person> list = new ArrayList<Person>();
        list.add(new Person("ZEBRA",8.5,75));
        list.add(new Person("RAHUL",9.5,70));
        list.add(new Person("ROSHAN",7.5,85));
        
        Collections.sort(list);
        System.out.println("AFTER SORTING");
        for(Person person: list){
            System.out.println(person.name+ " " +person.ht_in_inches + "  " + person.weight);
        }
    }   
    
}
