package hellojava;

/**
 * Description: describe your functionality
 * @author scull
 * @return what is my class or function going to return (eg: login() returns a boolean true/false)
 * @param What is my class or function going to be given (eg: login(String username, string password))
 */
public class MainDriver {
	//This is a comment. Text that does not execute. It is used for documentation
	/*
	 * this is a block comment
	 * you can put many comments in one block
	 * if you want.
	 */
	/**
	 * A driver class must include a main method. A main method is an entry for your program. It is the first thing that Java runs and looked for. Public means that the main method can be accessed from anywhere, including outside of the program. JVM will not be able to access it otherwise
     * A static method is a method that belongs to a specific class, it is the property of the main driver class.
     * Void is a keyword meaning the method is not going to return anything, it doesn't send anything anywhere. It just executes the code within the method
     * Main means this is fixed. Java FIRST LOOKS FOR THE MAIN METHOD. 
	 */
	public static void main(String[] args) {
		System.out.println("Hello World");
		
		for (String string : args) {
			System.out.println(string);
		}
	}
}
