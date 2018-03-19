public class Citizen implements Person{
    String name;
    Integer age;

    public Citizen(String name, Integer age) {
        this.name = name;
        this.age = age;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public Integer getAge() {
        return age;
    }
}
