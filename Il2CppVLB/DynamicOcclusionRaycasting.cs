using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AB RID: 171
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x06000BD5 RID: 3029 RVA: 0x000965C8 File Offset: 0x000947C8
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionRaycasting()
		{
			Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionRaycasting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr);
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "ClassName");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "dimensions");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "layerMask");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "considerTriggers");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minOccluderArea");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minSurfaceRatio");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "maxSurfaceDot");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeAlignment");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeOffset");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_CurrentHit");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_RangeMultiplier");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "<planeEquationWS>k__BackingField");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_PrevNonSubHitDirectionId");
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664738);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664739);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664740);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664741);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664742);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664743);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664744);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664745);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664746);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664747);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664748);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664749);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664750);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664751);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664752);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664753);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664754);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664755);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664756);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664757);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664758);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664759);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664760);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664761);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664762);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664763);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664764);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664765);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00096940 File Offset: 0x00094B40
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0009697C File Offset: 0x00094B7C
		public unsafe float fadeDistanceToPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000969BC File Offset: 0x00094BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83680, XrefRangeEnd = 83685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00096A0C File Offset: 0x00094C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83685, XrefRangeEnd = 83687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00096A50 File Offset: 0x00094C50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00096A98 File Offset: 0x00094C98
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00096AD4 File Offset: 0x00094CD4
		public unsafe Plane planeEquationWS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00096B14 File Offset: 0x00094D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83687, XrefRangeEnd = 83688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00096B50 File Offset: 0x00094D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83688, XrefRangeEnd = 83690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00096B8C File Offset: 0x00094D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83690, XrefRangeEnd = 83692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00096BC8 File Offset: 0x00094DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83692, XrefRangeEnd = 83703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00096BFC File Offset: 0x00094DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83703, XrefRangeEnd = 83708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angleDiff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00096C54 File Offset: 0x00094E54
		public unsafe QueryTriggerInteraction queryTriggerInteraction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00096C90 File Offset: 0x00094E90
		public unsafe float raycastMaxDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83709, RefRangeEnd = 83711, XrefRangeStart = 83708, XrefRangeEnd = 83709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00096CCC File Offset: 0x00094ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83711, XrefRangeEnd = 83714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00096D20 File Offset: 0x00094F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83732, RefRangeEnd = 83735, XrefRangeStart = 83714, XrefRangeEnd = 83732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00096D74 File Offset: 0x00094F74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83755, RefRangeEnd = 83758, XrefRangeStart = 83735, XrefRangeEnd = 83755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00096DC8 File Offset: 0x00094FC8
		[CallerCount(0)]
		public unsafe uint GetDirectionCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00096E04 File Offset: 0x00095004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83770, RefRangeEnd = 83771, XrefRangeStart = 83758, XrefRangeEnd = 83770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDirection(uint dirInt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dirInt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00096E50 File Offset: 0x00095050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83771, XrefRangeEnd = 83772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(hit);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forwardVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00096EAC File Offset: 0x000950AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83772, XrefRangeEnd = 83806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00096F00 File Offset: 0x00095100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83821, RefRangeEnd = 83822, XrefRangeStart = 83806, XrefRangeEnd = 83821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHit(ref DynamicOcclusionRaycasting.HitResult hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(hit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00096F44 File Offset: 0x00095144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83826, RefRangeEnd = 83828, XrefRangeStart = 83822, XrefRangeEnd = 83826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHitNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00096F78 File Offset: 0x00095178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83828, XrefRangeEnd = 83841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00096FC8 File Offset: 0x000951C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83849, RefRangeEnd = 83851, XrefRangeStart = 83841, XrefRangeEnd = 83849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlane(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00097008 File Offset: 0x00095208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83851, XrefRangeEnd = 83853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlaneOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0009703C File Offset: 0x0009523C
		[CallerCount(0)]
		public unsafe void SetPlaneWS(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0009707C File Offset: 0x0009527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83853, XrefRangeEnd = 83861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00007E43 File Offset: 0x00006043
		public DynamicOcclusionRaycasting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000970B8 File Offset: 0x000952B8
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00007E4C File Offset: 0x0000604C
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000970D8 File Offset: 0x000952D8
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe Dimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00097100 File Offset: 0x00095300
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00007E79 File Offset: 0x00006079
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00097128 File Offset: 0x00095328
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00007E94 File Offset: 0x00006094
		public unsafe bool considerTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers)) = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00097150 File Offset: 0x00095350
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00007EAF File Offset: 0x000060AF
		public unsafe float minOccluderArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00097178 File Offset: 0x00095378
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00007ECA File Offset: 0x000060CA
		public unsafe float minSurfaceRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio)) = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000971A0 File Offset: 0x000953A0
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00007EE5 File Offset: 0x000060E5
		public unsafe float maxSurfaceDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x000971C8 File Offset: 0x000953C8
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00007F00 File Offset: 0x00006100
		public unsafe PlaneAlignment planeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment)) = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x000971F0 File Offset: 0x000953F0
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00007F1B File Offset: 0x0000611B
		public unsafe float planeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00097218 File Offset: 0x00095418
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00007F36 File Offset: 0x00006136
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00097240 File Offset: 0x00095440
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00007F51 File Offset: 0x00006151
		public DynamicOcclusionRaycasting.HitResult m_CurrentHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit);
				return new DynamicOcclusionRaycasting.HitResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00097270 File Offset: 0x00095470
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00007F7F File Offset: 0x0000617F
		public unsafe float m_RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier)) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00097298 File Offset: 0x00095498
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00007F9A File Offset: 0x0000619A
		public unsafe Plane _planeEquationWS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000972C0 File Offset: 0x000954C0
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00007FB5 File Offset: 0x000061B5
		public unsafe uint m_PrevNonSubHitDirectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId)) = value;
			}
		}

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_considerTriggers;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_minOccluderArea;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_minSurfaceRatio;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_maxSurfaceDot;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_planeAlignment;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_planeOffset;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_m_RangeMultiplier;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr__planeEquationWS_k__BackingField;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevNonSubHitDirectionId;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_SetHitNull_Private_Void_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000831 RID: 2097
		public sealed class HitResult : ValueType
		{
			// Token: 0x0600BEDA RID: 48858 RVA: 0x002ED328 File Offset: 0x002EB528
			// Note: this type is marked as 'beforefieldinit'.
			static HitResult()
			{
				Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "HitResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr);
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "point");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "normal");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "distance");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider2D");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider3D");
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664766);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664767);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664768);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664769);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664770);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664771);
			}

			// Token: 0x0600BEDB RID: 48859 RVA: 0x002ED430 File Offset: 0x002EB630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83642, XrefRangeEnd = 83648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit hit3D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit3D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEDC RID: 48860 RVA: 0x002ED47C File Offset: 0x002EB67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83648, XrefRangeEnd = 83654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit2D hit2D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit2D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B5B RID: 15195
			// (get) Token: 0x0600BEDD RID: 48861 RVA: 0x002ED4C8 File Offset: 0x002EB6C8
			public unsafe bool hasCollider
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 83658, RefRangeEnd = 83662, XrefRangeStart = 83654, XrefRangeEnd = 83658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B5C RID: 15196
			// (get) Token: 0x0600BEDE RID: 48862 RVA: 0x002ED50C File Offset: 0x002EB70C
			public unsafe string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83662, XrefRangeEnd = 83671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003B5D RID: 15197
			// (get) Token: 0x0600BEDF RID: 48863 RVA: 0x002ED548 File Offset: 0x002EB748
			public unsafe Bounds bounds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83671, XrefRangeEnd = 83678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEE0 RID: 48864 RVA: 0x002ED58C File Offset: 0x002EB78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83678, XrefRangeEnd = 83680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNull()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEE1 RID: 48865 RVA: 0x0005D4B9 File Offset: 0x0005B6B9
			public HitResult(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BEE2 RID: 48866 RVA: 0x0005D4C2 File Offset: 0x0005B6C2
			public HitResult() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
			}

			// Token: 0x17003B56 RID: 15190
			// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x002ED5C4 File Offset: 0x002EB7C4
			// (set) Token: 0x0600BEE4 RID: 48868 RVA: 0x0005D4D4 File Offset: 0x0005B6D4
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17003B57 RID: 15191
			// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x002ED5EC File Offset: 0x002EB7EC
			// (set) Token: 0x0600BEE6 RID: 48870 RVA: 0x0005D4EF File Offset: 0x0005B6EF
			public unsafe Vector3 normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal)) = value;
				}
			}

			// Token: 0x17003B58 RID: 15192
			// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x002ED614 File Offset: 0x002EB814
			// (set) Token: 0x0600BEE8 RID: 48872 RVA: 0x0005D50A File Offset: 0x0005B70A
			public unsafe float distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance)) = value;
				}
			}

			// Token: 0x17003B59 RID: 15193
			// (get) Token: 0x0600BEE9 RID: 48873 RVA: 0x002ED63C File Offset: 0x002EB83C
			// (set) Token: 0x0600BEEA RID: 48874 RVA: 0x0005D525 File Offset: 0x0005B725
			public unsafe Collider2D collider2D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B5A RID: 15194
			// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x002ED66C File Offset: 0x002EB86C
			// (set) Token: 0x0600BEEC RID: 48876 RVA: 0x0005D544 File Offset: 0x0005B744
			public unsafe Collider collider3D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008159 RID: 33113
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x0400815A RID: 33114
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x0400815B RID: 33115
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x0400815C RID: 33116
			private static readonly IntPtr NativeFieldInfoPtr_collider2D;

			// Token: 0x0400815D RID: 33117
			private static readonly IntPtr NativeFieldInfoPtr_collider3D;

			// Token: 0x0400815E RID: 33118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0;

			// Token: 0x0400815F RID: 33119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0;

			// Token: 0x04008160 RID: 33120
			private static readonly IntPtr NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0;

			// Token: 0x04008161 RID: 33121
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008162 RID: 33122
			private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

			// Token: 0x04008163 RID: 33123
			private static readonly IntPtr NativeMethodInfoPtr_SetNull_Public_Void_0;
		}

		// Token: 0x02000832 RID: 2098
		[OriginalName("Assembly-CSharp.dll", "", "Direction")]
		public enum Direction
		{
			// Token: 0x04008165 RID: 33125
			Up,
			// Token: 0x04008166 RID: 33126
			Down,
			// Token: 0x04008167 RID: 33127
			Left,
			// Token: 0x04008168 RID: 33128
			Right,
			// Token: 0x04008169 RID: 33129
			Max2D = 1,
			// Token: 0x0400816A RID: 33130
			Max3D = 3
		}
	}
}
