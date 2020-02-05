
import java.util.ArrayList;
import java.util.List;
import java.util.stream.IntStream;

//public class IntStreamExample {
//
//    public static void main(String[] args) {
//        // printout the numbers from 1 to 100
//        IntStream.range(1, 11).forEach(s -> System.out.println(s));
//
//        // create a list of integers for 1 to 100
//        List<Integer> list = new ArrayList<>();
//        IntStream.range(1, 11).forEach(it -> list.add(it));
//        System.out.println("Size " + list.size());
//    }
//}

import java.util.Random;
import java.util.stream.Collectors;

public class IntStreamExample {

    public static void main(String[] args) {
        Random random = new Random();
        // Generate a list of random task
        List<Task> values = new ArrayList<>();
        IntStream.range(1, 20).forEach(i -> values.add(new Task("Task" + random.nextInt(10), random.nextInt(10))));


        // get a list of the distinct task summary field
        List<String> resultList =
                    values.stream()
//                    		.filter(t -> t.getDuration() > 5)
		                    .map(t -> t.getSummary())
		                    .distinct()
		                    .collect(Collectors.toList());
        System.out.println(resultList);


        // get a concatenated string of Task with a duration longer than 5 hours
        String collect =
                values.stream()
                		.filter(t -> t.getDuration() > 5)
				        .map(t -> t.getSummary())
		                .distinct()
		                .collect(Collectors.joining("-"));
        System.out.println(collect);
    }

}