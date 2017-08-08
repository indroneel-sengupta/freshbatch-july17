/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package interfaces;

/**
 *
 * @author Indroneel Sengupta
 */
class Employee implements Cloneable{
    private String dob;
    public String getDob(){ return this.dob ;}
    public void setDob(String str) {this.dob = str;}
    Employee(String str){
        this.dob = str;
    }  
    public Object clone(){
         
                try{
                   return (super.clone());
                }catch(Exception e){
                    return null;
                }
    }
    
}


public class Clone {
    public static void main(String args[]){
        System.out.println("HELLO");
        Employee e1 = new Employee("2-7-1995");
        String str = e1.getDob();
        System.out.println(str);
        Employee e2 = (Employee) e1.clone();
        e2.setDob("2-12-1995");
        String str2 = e2.getDob();
        str = e1.getDob();
        System.out.println(str2);
        System.out.println(str);


    }
    
}
