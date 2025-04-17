using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x020000A8 RID: 168
	public class BeamGeometrySD : BeamGeometryAbstractBase
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x00094754 File Offset: 0x00092954
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometrySD()
		{
			Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometrySD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr);
			BeamGeometrySD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_Master");
			BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CurrentMeshType");
			BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_MaterialModifierCallback");
			BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CoFadeOut");
			BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CurrentCameraRenderingSRP");
			BeamGeometrySD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664651);
			BeamGeometrySD.NativeMethodInfoPtr_get_visible_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664652);
			BeamGeometrySD.NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664653);
			BeamGeometrySD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664654);
			BeamGeometrySD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664655);
			BeamGeometrySD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664656);
			BeamGeometrySD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664657);
			BeamGeometrySD.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664658);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664659);
			BeamGeometrySD.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664660);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664661);
			BeamGeometrySD.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664662);
			BeamGeometrySD.NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664663);
			BeamGeometrySD.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664664);
			BeamGeometrySD.NativeMethodInfoPtr_OnMasterEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664665);
			BeamGeometrySD.NativeMethodInfoPtr_OnMasterDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664666);
			BeamGeometrySD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664667);
			BeamGeometrySD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664668);
			BeamGeometrySD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664669);
			BeamGeometrySD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664670);
			BeamGeometrySD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664671);
			BeamGeometrySD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664672);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664673);
			BeamGeometrySD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664674);
			BeamGeometrySD.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664675);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664676);
			BeamGeometrySD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664677);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664678);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664679);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664680);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664681);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664682);
			BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664683);
			BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664684);
			BeamGeometrySD.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664685);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664686);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664687);
			BeamGeometrySD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664688);
			BeamGeometrySD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664689);
			BeamGeometrySD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664690);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664691);
			BeamGeometrySD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664692);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00094B30 File Offset: 0x00092D30
		[CallerCount(0)]
		public unsafe override VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometrySD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00094B7C File Offset: 0x00092D7C
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00094BB8 File Offset: 0x00092DB8
		public unsafe bool visible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82783, XrefRangeEnd = 82785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_visible_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 82787, RefRangeEnd = 82796, XrefRangeStart = 82785, XrefRangeEnd = 82787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00094BF8 File Offset: 0x00092DF8
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00094C34 File Offset: 0x00092E34
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82796, XrefRangeEnd = 82798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82798, XrefRangeEnd = 82800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00094C74 File Offset: 0x00092E74
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00094CB0 File Offset: 0x00092EB0
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82800, XrefRangeEnd = 82802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82802, XrefRangeEnd = 82804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00094CF0 File Offset: 0x00092EF0
		public unsafe bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00094D2C File Offset: 0x00092F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82804, XrefRangeEnd = 82806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeFadeOutFactor(Transform camTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00094D7C File Offset: 0x00092F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82806, XrefRangeEnd = 82811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdateFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00094DBC File Offset: 0x00092FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82823, RefRangeEnd = 82824, XrefRangeStart = 82811, XrefRangeEnd = 82823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeFadeOutFactor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00094DF0 File Offset: 0x00092FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82834, RefRangeEnd = 82835, XrefRangeStart = 82824, XrefRangeEnd = 82834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFadeOutFactorProp(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00094E30 File Offset: 0x00093030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82835, XrefRangeEnd = 82837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFadeOutCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00094E64 File Offset: 0x00093064
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 82850, RefRangeEnd = 82856, XrefRangeStart = 82837, XrefRangeEnd = 82850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestartFadeOutCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00094E98 File Offset: 0x00093098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82856, XrefRangeEnd = 82859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMasterEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnMasterEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00094ECC File Offset: 0x000930CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82859, XrefRangeEnd = 82863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMasterDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnMasterDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00094F00 File Offset: 0x00093100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82863, XrefRangeEnd = 82875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00094F34 File Offset: 0x00093134
		public unsafe static bool isCustomRenderPipelineSupported
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00094F64 File Offset: 0x00093164
		public unsafe bool shouldUseGPUInstancedMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82875, XrefRangeEnd = 82876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00094FA0 File Offset: 0x000931A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82876, XrefRangeEnd = 82889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00094FD4 File Offset: 0x000931D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82941, RefRangeEnd = 82942, XrefRangeStart = 82889, XrefRangeEnd = 82941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(VolumetricLightBeamSD master)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00095018 File Offset: 0x00093218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82984, RefRangeEnd = 82985, XrefRangeStart = 82942, XrefRangeEnd = 82984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateMesh(bool masterEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref masterEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00095058 File Offset: 0x00093258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82985, XrefRangeEnd = 82993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeLocalMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00095094 File Offset: 0x00093294
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82993, XrefRangeEnd = 82994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000950D0 File Offset: 0x000932D0
		public unsafe bool isDepthBlendEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82994, XrefRangeEnd = 82995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0009510C File Offset: 0x0009330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82995, XrefRangeEnd = 83003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00095148 File Offset: 0x00093348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83035, RefRangeEnd = 83037, XrefRangeStart = 83003, XrefRangeEnd = 83035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00095184 File Offset: 0x00093384
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 83046, RefRangeEnd = 83057, XrefRangeStart = 83037, XrefRangeEnd = 83046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000951D0 File Offset: 0x000933D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 83066, RefRangeEnd = 83076, XrefRangeStart = 83057, XrefRangeEnd = 83066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0009521C File Offset: 0x0009341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83076, XrefRangeEnd = 83085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00095268 File Offset: 0x00093468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83094, RefRangeEnd = 83097, XrefRangeStart = 83085, XrefRangeEnd = 83094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000952B4 File Offset: 0x000934B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83097, XrefRangeEnd = 83107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00095304 File Offset: 0x00093504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83116, RefRangeEnd = 83119, XrefRangeStart = 83107, XrefRangeEnd = 83116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00095338 File Offset: 0x00093538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83128, RefRangeEnd = 83131, XrefRangeStart = 83119, XrefRangeEnd = 83128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0009536C File Offset: 0x0009356C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83131, XrefRangeEnd = 83137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000953C0 File Offset: 0x000935C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83269, RefRangeEnd = 83273, XrefRangeStart = 83137, XrefRangeEnd = 83269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialAndBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000953F4 File Offset: 0x000935F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83287, RefRangeEnd = 83289, XrefRangeStart = 83273, XrefRangeEnd = 83287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00095428 File Offset: 0x00093628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83289, XrefRangeEnd = 83290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00095478 File Offset: 0x00093678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83290, XrefRangeEnd = 83302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000954AC File Offset: 0x000936AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83302, XrefRangeEnd = 83311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000954F0 File Offset: 0x000936F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83346, RefRangeEnd = 83348, XrefRangeStart = 83311, XrefRangeEnd = 83346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraRelatedProperties(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00095534 File Offset: 0x00093734
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometrySD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00007BF0 File Offset: 0x00005DF0
		public BeamGeometrySD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00095570 File Offset: 0x00093770
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00007BF9 File Offset: 0x00005DF9
		public unsafe VolumetricLightBeamSD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x000955A0 File Offset: 0x000937A0
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00007C18 File Offset: 0x00005E18
		public unsafe MeshType m_CurrentMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x000955C8 File Offset: 0x000937C8
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x00007C33 File Offset: 0x00005E33
		public unsafe MaterialModifier.Callback m_MaterialModifierCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialModifier.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x000955F8 File Offset: 0x000937F8
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x00007C52 File Offset: 0x00005E52
		public unsafe Coroutine m_CoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00095628 File Offset: 0x00093828
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00007C71 File Offset: 0x00005E71
		public unsafe Camera m_CurrentCameraRenderingSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMeshType;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallback;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_m_CoFadeOut;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRenderingSRP;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Private_get_Boolean_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_OnMasterEnable_Public_Void_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_OnMasterDisable_Public_Void_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200082E RID: 2094
		[ObfuscatedName("VLB.BeamGeometrySD+<CoUpdateFadeOut>d__17")]
		public sealed class _CoUpdateFadeOut_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600BEC4 RID: 48836 RVA: 0x002ECF08 File Offset: 0x002EB108
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdateFadeOut_d__17()
			{
				Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "<CoUpdateFadeOut>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>1__state");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>2__current");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>4__this");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664693);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664694);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664695);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664696);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664697);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664698);
			}

			// Token: 0x0600BEC5 RID: 48837 RVA: 0x002ECFE8 File Offset: 0x002EB1E8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdateFadeOut_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEC6 RID: 48838 RVA: 0x002ED030 File Offset: 0x002EB230
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEC7 RID: 48839 RVA: 0x002ED064 File Offset: 0x002EB264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82776, XrefRangeEnd = 82778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B52 RID: 15186
			// (get) Token: 0x0600BEC8 RID: 48840 RVA: 0x002ED0A0 File Offset: 0x002EB2A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEC9 RID: 48841 RVA: 0x002ED0E0 File Offset: 0x002EB2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82778, XrefRangeEnd = 82783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B53 RID: 15187
			// (get) Token: 0x0600BECA RID: 48842 RVA: 0x002ED114 File Offset: 0x002EB314
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BECB RID: 48843 RVA: 0x0005D42A File Offset: 0x0005B62A
			public _CoUpdateFadeOut_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B4F RID: 15183
			// (get) Token: 0x0600BECC RID: 48844 RVA: 0x002ED154 File Offset: 0x002EB354
			// (set) Token: 0x0600BECD RID: 48845 RVA: 0x0005D433 File Offset: 0x0005B633
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B50 RID: 15184
			// (get) Token: 0x0600BECE RID: 48846 RVA: 0x002ED17C File Offset: 0x002EB37C
			// (set) Token: 0x0600BECF RID: 48847 RVA: 0x0005D44E File Offset: 0x0005B64E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B51 RID: 15185
			// (get) Token: 0x0600BED0 RID: 48848 RVA: 0x002ED1AC File Offset: 0x002EB3AC
			// (set) Token: 0x0600BED1 RID: 48849 RVA: 0x0005D46D File Offset: 0x0005B66D
			public unsafe BeamGeometrySD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeamGeometrySD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008147 RID: 33095
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008148 RID: 33096
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008149 RID: 33097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400814A RID: 33098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400814B RID: 33099
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400814C RID: 33100
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400814D RID: 33101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400814E RID: 33102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400814F RID: 33103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
