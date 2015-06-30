﻿using System;

namespace HackerCentral.School {
   public class SchoolAssignment {
      private SchoolGradeContainer container;
      private DateTime dueDate;
      private string name;
      private float outOf;
      private float grade;

      // getter methods
      public SchoolGradeContainer getContainer() { return container; }
      public DateTime getDueDate() { return dueDate; }
      public string getName() { return name; }
      public float getOutOf() { return outOf; }
      public float getGrade() { return grade; }

      // setter methods
      public void setContainer(SchoolGradeContainer param) { container = param; }
      public void setDueDate(DateTime param) { dueDate = param; }
      public void setName(string param) { name = param; }
      public void setOutOf(float param) { outOf = param; }
      public void setGrade(float param) { grade = param; }
   }
}