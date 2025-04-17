using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x02000097 RID: 151
	public class BeamGeometryHD : BeamGeometryAbstractBase
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x0008DD88 File Offset: 0x0008BF88
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometryHD()
		{
			Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometryHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr);
			BeamGeometryHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Master");
			BeamGeometryHD.NativeFieldInfoPtr_m_Cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Cookie");
			BeamGeometryHD.NativeFieldInfoPtr_m_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Shadow");
			BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_CurrentCameraRenderingSRP");
			BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_DirtyProps");
			BeamGeometryHD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664335);
			BeamGeometryHD.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664336);
			BeamGeometryHD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664337);
			BeamGeometryHD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664338);
			BeamGeometryHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664339);
			BeamGeometryHD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664340);
			BeamGeometryHD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664341);
			BeamGeometryHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664342);
			BeamGeometryHD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664343);
			BeamGeometryHD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664344);
			BeamGeometryHD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664345);
			BeamGeometryHD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664346);
			BeamGeometryHD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664347);
			BeamGeometryHD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664348);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664349);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664350);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664351);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664352);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664353);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664354);
			BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664355);
			BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664356);
			BeamGeometryHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664357);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664358);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664359);
			BeamGeometryHD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664360);
			BeamGeometryHD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664361);
			BeamGeometryHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664362);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664363);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664364);
			BeamGeometryHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100664365);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0008E088 File Offset: 0x0008C288
		[CallerCount(0)]
		public unsafe override VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometryHD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x17000317 RID: 791
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0008E0D4 File Offset: 0x0008C2D4
		public unsafe bool visible
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80313, RefRangeEnd = 80316, XrefRangeStart = 80308, XrefRangeEnd = 80313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000318 RID: 792
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0008E114 File Offset: 0x0008C314
		public unsafe int sortingLayerID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80321, RefRangeEnd = 80323, XrefRangeStart = 80316, XrefRangeEnd = 80321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000319 RID: 793
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0008E154 File Offset: 0x0008C354
		public unsafe int sortingOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80328, RefRangeEnd = 80329, XrefRangeStart = 80323, XrefRangeEnd = 80328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0008E194 File Offset: 0x0008C394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80329, XrefRangeEnd = 80337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0008E1C8 File Offset: 0x0008C3C8
		public unsafe static bool isCustomRenderPipelineSupported
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0008E1F8 File Offset: 0x0008C3F8
		public unsafe bool shouldUseGPUInstancedMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80343, RefRangeEnd = 80345, XrefRangeStart = 80337, XrefRangeEnd = 80343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0008E234 File Offset: 0x0008C434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80345, XrefRangeEnd = 80352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0008E268 File Offset: 0x0008C468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80432, RefRangeEnd = 80433, XrefRangeStart = 80352, XrefRangeEnd = 80432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(VolumetricLightBeamHD master)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0008E2AC File Offset: 0x0008C4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80449, RefRangeEnd = 80450, XrefRangeStart = 80433, XrefRangeEnd = 80449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0008E2E0 File Offset: 0x0008C4E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80458, RefRangeEnd = 80460, XrefRangeStart = 80450, XrefRangeEnd = 80458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeLocalMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0008E31C File Offset: 0x0008C51C
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80460, XrefRangeEnd = 80462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0008E358 File Offset: 0x0008C558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80475, RefRangeEnd = 80476, XrefRangeStart = 80462, XrefRangeEnd = 80475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0008E394 File Offset: 0x0008C594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80492, RefRangeEnd = 80494, XrefRangeStart = 80476, XrefRangeEnd = 80492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0008E3D0 File Offset: 0x0008C5D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80503, RefRangeEnd = 80506, XrefRangeStart = 80494, XrefRangeEnd = 80503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0008E41C File Offset: 0x0008C61C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 80515, RefRangeEnd = 80527, XrefRangeStart = 80506, XrefRangeEnd = 80515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0008E468 File Offset: 0x0008C668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80527, XrefRangeEnd = 80536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0008E4B4 File Offset: 0x0008C6B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80545, RefRangeEnd = 80548, XrefRangeStart = 80536, XrefRangeEnd = 80545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0008E500 File Offset: 0x0008C700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80553, RefRangeEnd = 80555, XrefRangeStart = 80548, XrefRangeEnd = 80553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0008E550 File Offset: 0x0008C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80555, XrefRangeEnd = 80564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, BeamGeometryHD.InvalidTexture invalidTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invalidTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0008E59C File Offset: 0x0008C79C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80573, RefRangeEnd = 80575, XrefRangeStart = 80564, XrefRangeEnd = 80573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0008E5D0 File Offset: 0x0008C7D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80584, RefRangeEnd = 80586, XrefRangeStart = 80575, XrefRangeEnd = 80584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0008E604 File Offset: 0x0008C804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80593, RefRangeEnd = 80594, XrefRangeStart = 80586, XrefRangeEnd = 80593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyDirty(DirtyProps prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0008E644 File Offset: 0x0008C844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80602, RefRangeEnd = 80604, XrefRangeStart = 80594, XrefRangeEnd = 80602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialAndBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0008E678 File Offset: 0x0008C878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80618, RefRangeEnd = 80620, XrefRangeStart = 80604, XrefRangeEnd = 80618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0008E6AC File Offset: 0x0008C8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80620, XrefRangeEnd = 80621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0008E6FC File Offset: 0x0008C8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80621, XrefRangeEnd = 80637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0008E730 File Offset: 0x0008C930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80637, XrefRangeEnd = 80650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0008E774 File Offset: 0x0008C974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80720, RefRangeEnd = 80721, XrefRangeStart = 80650, XrefRangeEnd = 80720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDirtyMaterialProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0008E7A8 File Offset: 0x0008C9A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80768, RefRangeEnd = 80770, XrefRangeStart = 80721, XrefRangeEnd = 80768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialPropertiesForCamera(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0008E7EC File Offset: 0x0008C9EC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometryHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000072DA File Offset: 0x000054DA
		public BeamGeometryHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0008E828 File Offset: 0x0008CA28
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000072E3 File Offset: 0x000054E3
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0008E858 File Offset: 0x0008CA58
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00007302 File Offset: 0x00005502
		public unsafe VolumetricCookieHD m_Cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Cookie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricCookieHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Cookie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0008E888 File Offset: 0x0008CA88
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00007321 File Offset: 0x00005521
		public unsafe VolumetricShadowHD m_Shadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Shadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Shadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0008E8B8 File Offset: 0x0008CAB8
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00007340 File Offset: 0x00005540
		public unsafe Camera m_CurrentCameraRenderingSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0008E8E8 File Offset: 0x0008CAE8
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0000735F File Offset: 0x0000555F
		public unsafe DirtyProps m_DirtyProps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps)) = value;
			}
		}

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_m_Cookie;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_m_Shadow;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRenderingSRP;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_m_DirtyProps;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMesh_Public_Void_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200081B RID: 2075
		[OriginalName("Assembly-CSharp.dll", "", "InvalidTexture")]
		public enum InvalidTexture
		{
			// Token: 0x040080C9 RID: 32969
			Null,
			// Token: 0x040080CA RID: 32970
			NoDepth
		}
	}
}
