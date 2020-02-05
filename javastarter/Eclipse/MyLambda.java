import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MyLambda {
	public static void main(String[] args) {
		List<String> list1 = Arrays.asList("vogella.com","google.com","heise.de" );
		list1.forEach(System.out::println); //Interchangeable with below
		
		List<String> list = new ArrayList<>();
		list.add("vog.com");
		list.add("gog.com");
		list.add("hes.de");
		list.forEach(s-> System.out.println(s));
	}
}
