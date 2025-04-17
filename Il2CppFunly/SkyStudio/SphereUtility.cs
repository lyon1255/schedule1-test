﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000123 RID: 291
	public class SphereUtility : Il2CppSystem.Object
	{
		// Token: 0x060018B5 RID: 6325 RVA: 0x000BD748 File Offset: 0x000BB948
		// Note: this type is marked as 'beforefieldinit'.
		static SphereUtility()
		{
			Il2CppClassPointerStore<SphereUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SphereUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr);
			SphereUtility.NativeFieldInfoPtr_k_HalfPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, "k_HalfPI");
			SphereUtility.NativeMethodInfoPtr_DirectionToSphericalCoordinate_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665920);
			SphereUtility.NativeMethodInfoPtr_SphericalCoordinateToDirection_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665921);
			SphereUtility.NativeMethodInfoPtr_RadiusAtHeight_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665922);
			SphereUtility.NativeMethodInfoPtr_SphericalToPoint_Public_Static_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665923);
			SphereUtility.NativeMethodInfoPtr_RadAngleToPercent_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665924);
			SphereUtility.NativeMethodInfoPtr_PercentToRadAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665925);
			SphereUtility.NativeMethodInfoPtr_HeightToPercent_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665926);
			SphereUtility.NativeMethodInfoPtr_PercentToHeight_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665927);
			SphereUtility.NativeMethodInfoPtr_AngleToReachTarget_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665928);
			SphereUtility.NativeMethodInfoPtr_Atan2Positive_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665929);
			SphereUtility.NativeMethodInfoPtr_RotateAroundXAxis_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665930);
			SphereUtility.NativeMethodInfoPtr_RotateAroundYAxis_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665931);
			SphereUtility.NativeMethodInfoPtr_RotatePoint_Public_Static_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665932);
			SphereUtility.NativeMethodInfoPtr_Rotate2d_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665933);
			SphereUtility.NativeMethodInfoPtr_Matrix2x2Mult_Public_Static_Vector2_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665934);
			SphereUtility.NativeMethodInfoPtr_CalculateStarRotation_Public_Static_Void_Vector3_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665935);
			SphereUtility.NativeMethodInfoPtr_ConvertUVToSphericalCoordinate_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665936);
			SphereUtility.NativeMethodInfoPtr_ConvertSphericalCoordateToUV_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665937);
			SphereUtility.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr, 100665938);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000BD908 File Offset: 0x000BBB08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95711, RefRangeEnd = 95713, XrefRangeStart = 95705, XrefRangeEnd = 95711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 DirectionToSphericalCoordinate(Vector3 direction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_DirectionToSphericalCoordinate_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000BD948 File Offset: 0x000BBB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95713, XrefRangeEnd = 95717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SphericalCoordinateToDirection(Vector2 coord)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_SphericalCoordinateToDirection_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000BD988 File Offset: 0x000BBB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95717, XrefRangeEnd = 95719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RadiusAtHeight(float yPos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_RadiusAtHeight_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000BD9C8 File Offset: 0x000BBBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95719, XrefRangeEnd = 95723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SphericalToPoint(float yPosition, float radAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_SphericalToPoint_Public_Static_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000BDA14 File Offset: 0x000BBC14
		[CallerCount(0)]
		public unsafe static float RadAngleToPercent(float radAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref radAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_RadAngleToPercent_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000BDA54 File Offset: 0x000BBC54
		[CallerCount(0)]
		public unsafe static float PercentToRadAngle(float percent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_PercentToRadAngle_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000BDA94 File Offset: 0x000BBC94
		[CallerCount(0)]
		public unsafe static float HeightToPercent(float yValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_HeightToPercent_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000BDAD4 File Offset: 0x000BBCD4
		[CallerCount(0)]
		public unsafe static float PercentToHeight(float hPercent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_PercentToHeight_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000BDB14 File Offset: 0x000BBD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95723, XrefRangeEnd = 95724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AngleToReachTarget(Vector2 point, float targetAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_AngleToReachTarget_Public_Static_Single_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000BDB60 File Offset: 0x000BBD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95724, XrefRangeEnd = 95725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan2Positive(float y, float x)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_Atan2Positive_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000BDBAC File Offset: 0x000BBDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95725, XrefRangeEnd = 95726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RotateAroundXAxis(Vector3 point, float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_RotateAroundXAxis_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000BDBF8 File Offset: 0x000BBDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95726, XrefRangeEnd = 95727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RotateAroundYAxis(Vector3 point, float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_RotateAroundYAxis_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x000BDC44 File Offset: 0x000BBE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95727, XrefRangeEnd = 95729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisRotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAxisRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_RotatePoint_Public_Static_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000BDCA0 File Offset: 0x000BBEA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 95733, RefRangeEnd = 95738, XrefRangeStart = 95729, XrefRangeEnd = 95733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Rotate2d(Vector2 pos, float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_Rotate2d_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000BDCEC File Offset: 0x000BBEEC
		[CallerCount(0)]
		public unsafe static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref matrix;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_Matrix2x2Mult_Public_Static_Vector2_Vector4_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000BDD38 File Offset: 0x000BBF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95738, XrefRangeEnd = 95741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref star;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &xRotationAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &yRotationAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_CalculateStarRotation_Public_Static_Void_Vector3_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000BDD88 File Offset: 0x000BBF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95741, XrefRangeEnd = 95743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ConvertUVToSphericalCoordinate(Vector2 uv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uv;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_ConvertUVToSphericalCoordinate_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000BDDC8 File Offset: 0x000BBFC8
		[CallerCount(0)]
		public unsafe static Vector2 ConvertSphericalCoordateToUV(Vector2 sphereCoord)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sphereCoord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr_ConvertSphericalCoordateToUV_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000BDE08 File Offset: 0x000BC008
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SphereUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereUtility.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0000E2DF File Offset: 0x0000C4DF
		public SphereUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000BDE44 File Offset: 0x000BC044
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		public unsafe static float k_HalfPI
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SphereUtility.NativeFieldInfoPtr_k_HalfPI, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SphereUtility.NativeFieldInfoPtr_k_HalfPI, (void*)(&value));
			}
		}

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_k_HalfPI;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_DirectionToSphericalCoordinate_Public_Static_Vector2_Vector3_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_SphericalCoordinateToDirection_Public_Static_Vector3_Vector2_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_RadiusAtHeight_Public_Static_Single_Single_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_SphericalToPoint_Public_Static_Vector3_Single_Single_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_RadAngleToPercent_Public_Static_Single_Single_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_PercentToRadAngle_Public_Static_Single_Single_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_HeightToPercent_Public_Static_Single_Single_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_PercentToHeight_Public_Static_Single_Single_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_AngleToReachTarget_Public_Static_Single_Vector2_Single_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_Atan2Positive_Public_Static_Single_Single_Single_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundXAxis_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundYAxis_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_RotatePoint_Public_Static_Vector3_Vector3_Single_Single_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_Rotate2d_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_Matrix2x2Mult_Public_Static_Vector2_Vector4_Vector2_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_CalculateStarRotation_Public_Static_Void_Vector3_byref_Single_byref_Single_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUVToSphericalCoordinate_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSphericalCoordateToUV_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
