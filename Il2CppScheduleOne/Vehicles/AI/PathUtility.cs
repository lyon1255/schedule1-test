using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000503 RID: 1283
	public static class PathUtility : Il2CppSystem.Object
	{
		// Token: 0x060070F5 RID: 28917 RVA: 0x001EFECC File Offset: 0x001EE0CC
		// Note: this type is marked as 'beforefieldinit'.
		static PathUtility()
		{
			Il2CppClassPointerStore<PathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathUtility>.NativeClassPtr);
			PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677507);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677508);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677509);
			PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677510);
			PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677511);
			PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677512);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677513);
			PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677514);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677515);
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x001EFFB0 File Offset: 0x001EE1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222064, XrefRangeEnd = 222068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x001F001C File Offset: 0x001EE21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222068, XrefRangeEnd = 222070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x001F007C File Offset: 0x001EE27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222070, XrefRangeEnd = 222071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x001F00F8 File Offset: 0x001EE2F8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 222099, RefRangeEnd = 222110, XrefRangeStart = 222071, XrefRangeEnd = 222099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x001F0164 File Offset: 0x001EE364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222110, XrefRangeEnd = 222127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x001F01D0 File Offset: 0x001EE3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222127, XrefRangeEnd = 222135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flatCarPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_from;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_to;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x001F0250 File Offset: 0x001EE450
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 222154, RefRangeEnd = 222167, XrefRangeStart = 222135, XrefRangeEnd = 222154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startPointIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x001F02CC File Offset: 0x001EE4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222167, XrefRangeEnd = 222171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x001F032C File Offset: 0x001EE52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222171, XrefRangeEnd = 222175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00035A6F File Offset: 0x00033C6F
		public PathUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0;
	}
}
