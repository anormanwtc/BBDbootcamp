import java.util.Arrays;
import java.util.List;

public class JavaStreamExample {
    public static void main(String[] args) {
        List<String> list = Arrays.asList("Hello", "Streams", "Not");

        String result = list.stream()
//					        .filter(s->s.contains("e"))
					        .map(s-> s.toUpperCase())
        					.reduce("", (partial, newPart)-> partial + " " + newPart);
        					//reduce starts with partial = arg1 then modifies it with (partial, newPart) -> method)

        System.out.println(result + "!");
    }
}