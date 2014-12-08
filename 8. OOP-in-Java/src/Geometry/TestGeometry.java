package Geometry;

import Geometry.Interfaces.PerimeterMeasurable;
import Geometry.Interfaces.VolumeMeasurable;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;


public class TestGeometry {

	@SuppressWarnings("unused")
	public static void main(String[] args) {
		Shape[] shapeArray = new Shape[6];
		shapeArray[0] = new Triangle(2, 8, 2, 10, 20, 30);
		shapeArray[1] = new Circle(100, -1, 13);
		shapeArray[2] = new Rectangle(10, -70, 3, 22);
		shapeArray[3] = new SquarePyramid(1, -7, 3, 11, 1, 2);
		shapeArray[4] = new Cuboid(1, -7, 3, 11, 20, 30);
		shapeArray[5] = new Sphere(97, -12, 3, 50);
		
		for (Shape shape : shapeArray) {
			//System.out.println(shape);
		}
		
		List<Shape> largeVolumeShapes = Arrays.asList(shapeArray)
				.stream()
				.filter(s -> s instanceof VolumeMeasurable)
				.filter(v -> ((VolumeMeasurable) v)
						.getVolume() > 40)
						.collect(Collectors.toList());
		
		for (Shape shape : largeVolumeShapes) {
			//System.out.println(shape);
		}
		
		Comparator<Shape> byPerimeter = (s1, s2) -> {
			PerimeterMeasurable Shape1 = (PerimeterMeasurable) s1;
			PerimeterMeasurable Shape2 = (PerimeterMeasurable) s2;
			double perimeterShape1 = Shape1.getPerimeter();
			double perimeterShape2 = Shape2.getPerimeter();
			
			return perimeterShape1 < perimeterShape2 ? -1 :
				perimeterShape1 > perimeterShape2 ? 1 : 0;		
		};
		
		List<Shape> planeShapesByPerimeter = Arrays.asList(shapeArray)
				.stream()
				.filter(p -> p instanceof PlaneShape)
				.sorted(byPerimeter)
				.collect(Collectors.toList());
		
		for (Shape shape : planeShapesByPerimeter) {
			System.out.println(shape);
		}
	}
}
