using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A9 RID: 169
	public class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00095658 File Offset: 0x00093858
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionAbstractBase()
		{
			Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr);
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "ClassName");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "updateRate");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "waitXFrames");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "onOcclusionProcessed");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_TransformPacked");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_LastFrameRendered");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_Master");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_MaterialModifierCallbackCached");
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664699);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664700);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664701);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664702);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664703);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664704);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664705);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664706);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664707);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664708);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664709);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664710);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664711);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664712);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664713);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664714);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664715);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664716);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664718);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000958B8 File Offset: 0x00093AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83348, XrefRangeEnd = 83349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000958EC File Offset: 0x00093AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83349, XrefRangeEnd = 83353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00095930 File Offset: 0x00093B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83353, XrefRangeEnd = 83357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00095974 File Offset: 0x00093B74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83379, RefRangeEnd = 83382, XrefRangeStart = 83357, XrefRangeEnd = 83379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000959B4 File Offset: 0x00093BB4
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47045, RefRangeEnd = 47048, XrefRangeStart = 47045, XrefRangeEnd = 47048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000959F0 File Offset: 0x00093BF0
		[CallerCount(0)]
		public unsafe virtual string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00095A34 File Offset: 0x00093C34
		[CallerCount(0)]
		public unsafe virtual MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00095A7C File Offset: 0x00093C7C
		[CallerCount(0)]
		public unsafe virtual bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00095AD0 File Offset: 0x00093CD0
		[CallerCount(0)]
		public unsafe virtual void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00095B20 File Offset: 0x00093D20
		[CallerCount(0)]
		public unsafe virtual void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00095B5C File Offset: 0x00093D5C
		[CallerCount(0)]
		public unsafe virtual void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00095B98 File Offset: 0x00093D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83382, XrefRangeEnd = 83386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00095BD4 File Offset: 0x00093DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83386, XrefRangeEnd = 83388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00095C10 File Offset: 0x00093E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83388, XrefRangeEnd = 83435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00095C4C File Offset: 0x00093E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83451, RefRangeEnd = 83453, XrefRangeStart = 83435, XrefRangeEnd = 83451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00095C88 File Offset: 0x00093E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83453, XrefRangeEnd = 83463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRender(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00095CCC File Offset: 0x00093ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83463, XrefRangeEnd = 83465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableOcclusion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00095D00 File Offset: 0x00093F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83465, XrefRangeEnd = 83466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00095D3C File Offset: 0x00093F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83466, XrefRangeEnd = 83469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__24_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00007C90 File Offset: 0x00005E90
		public DynamicOcclusionAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00095D70 File Offset: 0x00093F70
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00007C99 File Offset: 0x00005E99
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00095D90 File Offset: 0x00093F90
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00007CAB File Offset: 0x00005EAB
		public unsafe DynamicOcclusionUpdateRate updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00095DB8 File Offset: 0x00093FB8
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00007CC6 File Offset: 0x00005EC6
		public unsafe int waitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00095DE0 File Offset: 0x00093FE0
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00007CE1 File Offset: 0x00005EE1
		public unsafe Action onOcclusionProcessed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00095E10 File Offset: 0x00094010
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00007D00 File Offset: 0x00005F00
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00095E2C File Offset: 0x0009402C
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00007D0E File Offset: 0x00005F0E
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00095E54 File Offset: 0x00094054
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00007D29 File Offset: 0x00005F29
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00095E7C File Offset: 0x0009407C
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00007D44 File Offset: 0x00005F44
		public unsafe VolumetricLightBeamSD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00095EAC File Offset: 0x000940AC
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00007D63 File Offset: 0x00005F63
		public unsafe MaterialModifier.Callback m_MaterialModifierCallbackCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialModifier.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_updateRate;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_waitXFrames;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_onOcclusionProcessed;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallbackCached;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_DisableOcclusion_Private_Void_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0;

		// Token: 0x0200082F RID: 2095
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x04008151 RID: 33105
			RenderLoop,
			// Token: 0x04008152 RID: 33106
			OnEnable,
			// Token: 0x04008153 RID: 33107
			EditorUpdate,
			// Token: 0x04008154 RID: 33108
			User
		}
	}
}
