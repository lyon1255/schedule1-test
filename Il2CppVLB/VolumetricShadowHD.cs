using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009E RID: 158
	public class VolumetricShadowHD : MonoBehaviour
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x000923D8 File Offset: 0x000905D8
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricShadowHD()
		{
			Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricShadowHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr);
			VolumetricShadowHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "ClassName");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Strength");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UpdateRate");
			VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_WaitXFrames");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LayerMask");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UseOcclusionCulling");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthMapResolution");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Master");
			VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_TransformPacked");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LastFrameRendered");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthCamera");
			VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_NeedToUpdateOcclusionNextFrame");
			VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664511);
			VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664512);
			VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664513);
			VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664514);
			VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664515);
			VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664516);
			VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664517);
			VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664518);
			VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664519);
			VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664520);
			VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664521);
			VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664522);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664523);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664524);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664525);
			VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664526);
			VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664527);
			VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664528);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664529);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664530);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664531);
			VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664532);
			VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664533);
			VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664534);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664535);
			VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664536);
			VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664537);
			VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664538);
			VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664539);
			VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664540);
			VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664541);
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00092778 File Offset: 0x00090978
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x000927B4 File Offset: 0x000909B4
		public unsafe float strength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81347, XrefRangeEnd = 81348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000927F4 File Offset: 0x000909F4
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00092830 File Offset: 0x00090A30
		public unsafe ShadowUpdateRate updateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00092870 File Offset: 0x00090A70
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x000928AC File Offset: 0x00090AAC
		public unsafe int waitXFrames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000928EC File Offset: 0x00090AEC
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00092928 File Offset: 0x00090B28
		public unsafe LayerMask layerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81348, XrefRangeEnd = 81349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00092968 File Offset: 0x00090B68
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000929A4 File Offset: 0x00090BA4
		public unsafe bool useOcclusionCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81349, XrefRangeEnd = 81354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000929E4 File Offset: 0x00090BE4
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00092A20 File Offset: 0x00090C20
		public unsafe int depthMapResolution
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45633, RefRangeEnd = 45634, XrefRangeStart = 45633, XrefRangeEnd = 45634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81354, XrefRangeEnd = 81373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00092A60 File Offset: 0x00090C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81373, XrefRangeEnd = 81374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00092A94 File Offset: 0x00090C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81381, RefRangeEnd = 81384, XrefRangeStart = 81374, XrefRangeEnd = 81381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00092AC8 File Offset: 0x00090CC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81405, RefRangeEnd = 81409, XrefRangeStart = 81384, XrefRangeEnd = 81405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00092B08 File Offset: 0x00090D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81430, RefRangeEnd = 81431, XrefRangeStart = 81409, XrefRangeEnd = 81430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(geom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00092B50 File Offset: 0x00090D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81431, XrefRangeEnd = 81435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00092B84 File Offset: 0x00090D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81435, XrefRangeEnd = 81441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00092BB8 File Offset: 0x00090DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81441, XrefRangeEnd = 81449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00092BEC File Offset: 0x00090DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81449, XrefRangeEnd = 81469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00092C20 File Offset: 0x00090E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81469, XrefRangeEnd = 81472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00092C54 File Offset: 0x00090E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81472, XrefRangeEnd = 81474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeamEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00092C88 File Offset: 0x00090E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81485, RefRangeEnd = 81487, XrefRangeStart = 81474, XrefRangeEnd = 81485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00092CDC File Offset: 0x00090EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81487, XrefRangeEnd = 81497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00092D10 File Offset: 0x00090F10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81506, RefRangeEnd = 81510, XrefRangeStart = 81497, XrefRangeEnd = 81506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00092D44 File Offset: 0x00090F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81567, RefRangeEnd = 81568, XrefRangeStart = 81510, XrefRangeEnd = 81567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateOrActivateDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00092D78 File Offset: 0x00090F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00092DAC File Offset: 0x00090FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81568, XrefRangeEnd = 81570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00092DE0 File Offset: 0x00090FE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81575, RefRangeEnd = 81578, XrefRangeStart = 81570, XrefRangeEnd = 81575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00092E14 File Offset: 0x00091014
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00092E50 File Offset: 0x00091050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81578, XrefRangeEnd = 81583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricShadowHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000078B9 File Offset: 0x00005AB9
		public VolumetricShadowHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00092E8C File Offset: 0x0009108C
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000078C2 File Offset: 0x00005AC2
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00092EAC File Offset: 0x000910AC
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000078D4 File Offset: 0x00005AD4
		public unsafe float m_Strength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00092ED4 File Offset: 0x000910D4
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000078EF File Offset: 0x00005AEF
		public unsafe ShadowUpdateRate m_UpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00092EFC File Offset: 0x000910FC
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0000790A File Offset: 0x00005B0A
		public unsafe int m_WaitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames)) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00092F24 File Offset: 0x00091124
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00007925 File Offset: 0x00005B25
		public unsafe LayerMask m_LayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask)) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00092F4C File Offset: 0x0009114C
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00007940 File Offset: 0x00005B40
		public unsafe bool m_UseOcclusionCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling)) = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00092F74 File Offset: 0x00091174
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0000795B File Offset: 0x00005B5B
		public unsafe int m_DepthMapResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution)) = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00092F9C File Offset: 0x0009119C
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00007976 File Offset: 0x00005B76
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00092FCC File Offset: 0x000911CC
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00007995 File Offset: 0x00005B95
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00092FF4 File Offset: 0x000911F4
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000079B0 File Offset: 0x00005BB0
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0009301C File Offset: 0x0009121C
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000079CB File Offset: 0x00005BCB
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0009304C File Offset: 0x0009124C
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000079EA File Offset: 0x00005BEA
		public unsafe bool m_NeedToUpdateOcclusionNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00093074 File Offset: 0x00091274
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00007A05 File Offset: 0x00005C05
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_Strength;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRate;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitXFrames;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_UseOcclusionCulling;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthMapResolution;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_get_strength_Public_get_Single_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Private_Void_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200081C RID: 2076
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x040080CC RID: 32972
			RenderLoop,
			// Token: 0x040080CD RID: 32973
			OnEnable,
			// Token: 0x040080CE RID: 32974
			EditorUpdate,
			// Token: 0x040080CF RID: 32975
			User
		}

		// Token: 0x0200081D RID: 2077
		[ObfuscatedName("VLB.VolumetricShadowHD+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BE5F RID: 48735 RVA: 0x002EB844 File Offset: 0x002E9A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr);
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9");
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9__39_0");
				VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664544);
				VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664545);
			}

			// Token: 0x0600BE60 RID: 48736 RVA: 0x002EB8C0 File Offset: 0x002E9AC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE61 RID: 48737 RVA: 0x002EB8FC File Offset: 0x002E9AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81341, XrefRangeEnd = 81347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateOrActivateDepthCamera_b__39_0(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE62 RID: 48738 RVA: 0x0005D22C File Offset: 0x0005B42C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B35 RID: 15157
			// (get) Token: 0x0600BE63 RID: 48739 RVA: 0x002EB940 File Offset: 0x002E9B40
			// (set) Token: 0x0600BE64 RID: 48740 RVA: 0x0005D235 File Offset: 0x0005B435
			public unsafe static VolumetricShadowHD.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B36 RID: 15158
			// (get) Token: 0x0600BE65 RID: 48741 RVA: 0x002EB968 File Offset: 0x002E9B68
			// (set) Token: 0x0600BE66 RID: 48742 RVA: 0x0005D247 File Offset: 0x0005B447
			public unsafe static Action<Camera> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040080D0 RID: 32976
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040080D1 RID: 32977
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040080D2 RID: 32978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040080D3 RID: 32979
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0;
		}
	}
}
