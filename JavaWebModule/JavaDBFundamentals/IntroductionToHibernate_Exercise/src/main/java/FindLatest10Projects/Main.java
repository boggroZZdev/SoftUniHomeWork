package FindLatest10Projects;

import entities.Project;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");

        EntityManager em = emf.createEntityManager();


        List<Project> projects = em.createQuery("SELECT p FROM Project AS p ORDER BY p.startDate DESC, p.name ASC ")
                .setMaxResults(10)
                .getResultList();

        projects.stream().forEach(x->{
            StringBuilder sb = new StringBuilder();

            sb.append("Project name: ").append(x.getName())
                    .append(System.lineSeparator()).append("        Project description: ").append(x.getDescription())
                    .append(System.lineSeparator()).append("        Project start date: ").append(x.getStartDate())
                    .append(System.lineSeparator()).append("        Project end date: ").append(x.getEndDate());
            System.out.println(sb);
        });

        em.close();
        emf.close();
    }
}
