using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AA RID: 170
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x00095EDC File Offset: 0x000940DC
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionDepthBuffer()
		{
			Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionDepthBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr);
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "ClassName");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "layerMask");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "useOcclusionCulling");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "depthMapResolution");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "m_DepthCamera");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "m_NeedToUpdateOcclusionNextFrame");
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664719);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664720);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664721);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664722);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664723);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664724);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664725);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664726);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664727);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664728);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664729);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664730);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664731);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664732);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664733);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100664734);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000960D8 File Offset: 0x000942D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83475, XrefRangeEnd = 83477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0009611C File Offset: 0x0009431C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77736, RefRangeEnd = 77743, XrefRangeStart = 77736, XrefRangeEnd = 77743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00096164 File Offset: 0x00094364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83477, XrefRangeEnd = 83480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00096198 File Offset: 0x00094398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83480, XrefRangeEnd = 83483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000961EC File Offset: 0x000943EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83483, XrefRangeEnd = 83493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00096220 File Offset: 0x00094420
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83502, RefRangeEnd = 83506, XrefRangeStart = 83493, XrefRangeEnd = 83502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00096254 File Offset: 0x00094454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83506, XrefRangeEnd = 83507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLayerMaskIssues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00096290 File Offset: 0x00094490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83507, XrefRangeEnd = 83510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000962CC File Offset: 0x000944CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83569, RefRangeEnd = 83570, XrefRangeStart = 83510, XrefRangeEnd = 83569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateOrActivateDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00096300 File Offset: 0x00094500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83570, XrefRangeEnd = 83571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0009633C File Offset: 0x0009453C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83571, XrefRangeEnd = 83578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00096378 File Offset: 0x00094578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000963B4 File Offset: 0x000945B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83578, XrefRangeEnd = 83599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000963F0 File Offset: 0x000945F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83599, XrefRangeEnd = 83619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00096424 File Offset: 0x00094624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83619, XrefRangeEnd = 83634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00096474 File Offset: 0x00094674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83634, XrefRangeEnd = 83642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionDepthBuffer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00007D82 File Offset: 0x00005F82
		public DynamicOcclusionDepthBuffer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x000964B0 File Offset: 0x000946B0
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00007D8B File Offset: 0x00005F8B
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000964D0 File Offset: 0x000946D0
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00007D9D File Offset: 0x00005F9D
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000964F8 File Offset: 0x000946F8
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public unsafe bool useOcclusionCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling)) = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00096520 File Offset: 0x00094720
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00007DD3 File Offset: 0x00005FD3
		public unsafe int depthMapResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution)) = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00096548 File Offset: 0x00094748
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00007DEE File Offset: 0x00005FEE
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00096570 File Offset: 0x00094770
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00007E09 File Offset: 0x00006009
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000965A0 File Offset: 0x000947A0
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00007E28 File Offset: 0x00006028
		public unsafe bool m_NeedToUpdateOcclusionNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame)) = value;
			}
		}

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_useOcclusionCulling;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_depthMapResolution;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000830 RID: 2096
		[ObfuscatedName("VLB.DynamicOcclusionDepthBuffer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BED2 RID: 48850 RVA: 0x002ED1DC File Offset: 0x002EB3DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr);
				DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr, "<>9");
				DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr, "<>9__15_0");
				DynamicOcclusionDepthBuffer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr, 100664736);
				DynamicOcclusionDepthBuffer.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__15_0_Internal_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr, 100664737);
			}

			// Token: 0x0600BED3 RID: 48851 RVA: 0x002ED258 File Offset: 0x002EB458
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BED4 RID: 48852 RVA: 0x002ED294 File Offset: 0x002EB494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83469, XrefRangeEnd = 83475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateOrActivateDepthCamera_b__15_0(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__15_0_Internal_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BED5 RID: 48853 RVA: 0x0005D48C File Offset: 0x0005B68C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B54 RID: 15188
			// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x002ED2D8 File Offset: 0x002EB4D8
			// (set) Token: 0x0600BED7 RID: 48855 RVA: 0x0005D495 File Offset: 0x0005B695
			public unsafe static DynamicOcclusionDepthBuffer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicOcclusionDepthBuffer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B55 RID: 15189
			// (get) Token: 0x0600BED8 RID: 48856 RVA: 0x002ED300 File Offset: 0x002EB500
			// (set) Token: 0x0600BED9 RID: 48857 RVA: 0x0005D4A7 File Offset: 0x0005B6A7
			public unsafe static Action<Camera> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionDepthBuffer.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008155 RID: 33109
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008156 RID: 33110
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04008157 RID: 33111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008158 RID: 33112
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__15_0_Internal_Void_Camera_0;
		}
	}
}
