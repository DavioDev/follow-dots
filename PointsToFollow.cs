using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class PointsToFollow : MonoBehaviour {

 public Transform[] points;

 public IEnumerator<Transform> GetPathEnumerator (){

 if (points == null || points.Length < 1) {
 yield break;
 }

 var direction = 1;
 var index = 0;

 while (true) {
 yield return points [index];

 if(points.Length == 1){
 continue;
 }

 if (index <= 0) {
 direction = 1;
 } else if (index >= points.Length - 1) {
 direction = -1;
 }
 index = index + direction;
 }


 }

 public void OnDrawGizmos(){
 if (points == null || points.Length < 2) {
 return;

 }
 for (var i = 1; i < points.Length; i++) {
 Gizmos.DrawLine (points [i - 1].position, points [i].position);
 }

 }
 
}