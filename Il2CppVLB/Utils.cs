using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B5 RID: 181
	public static class Utils : Il2CppSystem.Object
	{
		// Token: 0x06000D53 RID: 3411 RVA: 0x0009AFC0 File Offset: 0x000991C0
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kEpsilon");
			Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "ms_FloatPackingPrecision");
			Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kFloatPackingHighMinShaderLevel");
			Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664921);
			Utils.NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664922);
			Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664923);
			Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664924);
			Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664925);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664926);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664927);
			Utils.NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664928);
			Utils.NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664929);
			Utils.NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664930);
			Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664931);
			Utils.NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664932);
			Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664933);
			Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664934);
			Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664935);
			Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664936);
			Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664937);
			Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664938);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664939);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664940);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664941);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664942);
			Utils.NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664943);
			Utils.NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664944);
			Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664945);
			Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664946);
			Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664947);
			Utils.NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664948);
			Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664949);
			Utils.NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664950);
			Utils.NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664951);
			Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664952);
			Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664953);
			Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664954);
			Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664955);
			Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664956);
			Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664957);
			Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664958);
			Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664959);
			Utils.NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664960);
			Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664961);
			Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664962);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0009B374 File Offset: 0x00099574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84558, XrefRangeEnd = 84559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallOffEnd;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0009B3C0 File Offset: 0x000995C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84559, XrefRangeEnd = 84560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallOffEnd;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0009B40C File Offset: 0x0009960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84560, XrefRangeEnd = 84576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap<T>(ref T a, ref T b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0009B484 File Offset: 0x00099684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84591, RefRangeEnd = 84594, XrefRangeStart = 84576, XrefRangeEnd = 84591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPath(Transform current)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0009B4C0 File Offset: 0x000996C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84613, RefRangeEnd = 84617, XrefRangeStart = 84594, XrefRangeEnd = 84613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T NewWithComponent<T>(string name) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0009B500 File Offset: 0x00099700
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84629, XrefRangeStart = 84617, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0009B540 File Offset: 0x00099740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84629, XrefRangeEnd = 84638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0009B580 File Offset: 0x00099780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84638, XrefRangeEnd = 84646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForeachComponentsInAnyChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0009B5D8 File Offset: 0x000997D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84656, RefRangeEnd = 84659, XrefRangeStart = 84646, XrefRangeEnd = 84656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForeachComponentsInDirectChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0009B630 File Offset: 0x00099830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84672, RefRangeEnd = 84674, XrefRangeStart = 84659, XrefRangeEnd = 84672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupDepthCamera(Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, Vector3 beamLocalForward, Vector3 lossyScale, bool isScalable, Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(depthCamera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneApexOffsetZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGeometryDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusEnd;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beamLocalForward;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lossyScale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isScalable;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beamInternalLocalRotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldScaleMinNearClipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0009B6E8 File Offset: 0x000998E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84674, XrefRangeEnd = 84681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFlag(this Enum mask, Enum flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0009B734 File Offset: 0x00099934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84686, RefRangeEnd = 84687, XrefRangeStart = 84681, XrefRangeEnd = 84686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Divide(this Vector3 aVector, Vector3 scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0009B780 File Offset: 0x00099980
		[CallerCount(0)]
		public unsafe static Vector2 xy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0009B7C0 File Offset: 0x000999C0
		[CallerCount(0)]
		public unsafe static Vector2 xz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0009B800 File Offset: 0x00099A00
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 84687, RefRangeEnd = 84710, XrefRangeStart = 84687, XrefRangeEnd = 84687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 yz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0009B840 File Offset: 0x00099A40
		[CallerCount(0)]
		public unsafe static Vector2 yx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0009B880 File Offset: 0x00099A80
		[CallerCount(0)]
		public unsafe static Vector2 zx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0009B8C0 File Offset: 0x00099AC0
		[CallerCount(0)]
		public unsafe static Vector2 zy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0009B900 File Offset: 0x00099B00
		[CallerCount(0)]
		public unsafe static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0009B95C File Offset: 0x00099B5C
		[CallerCount(0)]
		public unsafe static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0009B9B8 File Offset: 0x00099BB8
		[CallerCount(0)]
		public unsafe static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0009BA14 File Offset: 0x00099C14
		[CallerCount(0)]
		public unsafe static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0009BA70 File Offset: 0x00099C70
		[CallerCount(0)]
		public unsafe static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec3;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0009BABC File Offset: 0x00099CBC
		[CallerCount(0)]
		public unsafe static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedNormal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0009BB08 File Offset: 0x00099D08
		[CallerCount(0)]
		public unsafe static float GetVolumeCubic(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0009BB48 File Offset: 0x00099D48
		[CallerCount(0)]
		public unsafe static float GetMaxArea2D(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0009BB88 File Offset: 0x00099D88
		[CallerCount(0)]
		public unsafe static Color Opaque(this Color self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0009BBC8 File Offset: 0x00099DC8
		[CallerCount(0)]
		public unsafe static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackAndWhite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0009BC14 File Offset: 0x00099E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84710, XrefRangeEnd = 84716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0009BC60 File Offset: 0x00099E60
		[CallerCount(0)]
		public unsafe static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0009BCAC File Offset: 0x00099EAC
		[CallerCount(0)]
		public unsafe static bool IsAlmostZero(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0009BCEC File Offset: 0x00099EEC
		[CallerCount(0)]
		public unsafe static bool IsValid(this Plane plane)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0009BD2C File Offset: 0x00099F2C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 84719, RefRangeEnd = 84744, XrefRangeStart = 84716, XrefRangeEnd = 84719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0009BD84 File Offset: 0x00099F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84744, XrefRangeEnd = 84746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShaderKeywordEnabled(string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0009BDC8 File Offset: 0x00099FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84753, RefRangeEnd = 84755, XrefRangeStart = 84746, XrefRangeEnd = 84753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0009BE18 File Offset: 0x0009A018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84755, XrefRangeEnd = 84760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Color> SampleInArray(this Gradient self, int samplesCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplesCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0009BE6C File Offset: 0x0009A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84760, XrefRangeEnd = 84764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 Vector4_Floor(Vector4 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0009BEAC File Offset: 0x0009A0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84764, XrefRangeEnd = 84768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0009BEF8 File Offset: 0x0009A0F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84773, RefRangeEnd = 84778, XrefRangeStart = 84768, XrefRangeEnd = 84773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0009BF28 File Offset: 0x0009A128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84783, RefRangeEnd = 84784, XrefRangeStart = 84778, XrefRangeEnd = 84783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAtLeastOneFlag(this Enum mask, Enum flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0009BF74 File Offset: 0x0009A174
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkCurrentSceneDirty()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0009BF9C File Offset: 0x0009A19C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkObjectDirty(UnityEngine.Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000088A8 File Offset: 0x00006AA8
		public Utils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0009BFD4 File Offset: 0x0009A1D4
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000088B1 File Offset: 0x00006AB1
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0009BFF0 File Offset: 0x0009A1F0
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x000088BF File Offset: 0x00006ABF
		public unsafe static Utils.FloatPackingPrecision ms_FloatPackingPrecision
		{
			get
			{
				Utils.FloatPackingPrecision result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0009C00C File Offset: 0x0009A20C
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x000088CD File Offset: 0x00006ACD
		public unsafe static int kFloatPackingHighMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_ms_FloatPackingPrecision;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0;

		// Token: 0x0200083D RID: 2109
		[OriginalName("Assembly-CSharp.dll", "", "FloatPackingPrecision")]
		public enum FloatPackingPrecision
		{
			// Token: 0x040081BC RID: 33212
			High = 64,
			// Token: 0x040081BD RID: 33213
			Low = 8,
			// Token: 0x040081BE RID: 33214
			Undef = 0
		}

		// Token: 0x0200083E RID: 2110
		private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
		{
			// Token: 0x040081BF RID: 33215
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200083F RID: 2111
		private sealed class MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>
		{
			// Token: 0x040081C0 RID: 33216
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000840 RID: 2112
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>
		{
			// Token: 0x040081C1 RID: 33217
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000841 RID: 2113
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>
		{
			// Token: 0x040081C2 RID: 33218
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000842 RID: 2114
		private sealed class MethodInfoStoreGeneric_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>
		{
			// Token: 0x040081C3 RID: 33219
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000843 RID: 2115
		private sealed class MethodInfoStoreGeneric_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>
		{
			// Token: 0x040081C4 RID: 33220
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
