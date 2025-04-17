using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005A RID: 90
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x0008524C File Offset: 0x0008344C
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurComponent()
		{
			Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MotionBlurComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr);
			MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_ReconstructionFilter");
			MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_FrameBlendingFilter");
			MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "m_FirstFrame");
			MotionBlurComponent.NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663979);
			MotionBlurComponent.NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663980);
			MotionBlurComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663981);
			MotionBlurComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663982);
			MotionBlurComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663983);
			MotionBlurComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663984);
			MotionBlurComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663985);
			MotionBlurComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663986);
			MotionBlurComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663987);
			MotionBlurComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663988);
			MotionBlurComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, 100663989);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00085394 File Offset: 0x00083594
		public unsafe MotionBlurComponent.ReconstructionFilter reconstructionFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77242, RefRangeEnd = 77245, XrefRangeStart = 77236, XrefRangeEnd = 77242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.ReconstructionFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000853D4 File Offset: 0x000835D4
		public unsafe MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 77265, RefRangeEnd = 77269, XrefRangeStart = 77245, XrefRangeEnd = 77265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.FrameBlendingFilter>(intPtr3) : null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00085414 File Offset: 0x00083614
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77269, XrefRangeEnd = 77273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00085450 File Offset: 0x00083650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77273, XrefRangeEnd = 77275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00085488 File Offset: 0x00083688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77275, XrefRangeEnd = 77277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000854BC File Offset: 0x000836BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77277, RefRangeEnd = 77278, XrefRangeStart = 77277, XrefRangeEnd = 77277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000854F8 File Offset: 0x000836F8
		[CallerCount(0)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00085534 File Offset: 0x00083734
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77278, RefRangeEnd = 77287, XrefRangeStart = 77278, XrefRangeEnd = 77278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00085568 File Offset: 0x00083768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77287, XrefRangeEnd = 77346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000855AC File Offset: 0x000837AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77346, XrefRangeEnd = 77347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000855E0 File Offset: 0x000837E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77347, XrefRangeEnd = 77350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00005E01 File Offset: 0x00004001
		public MotionBlurComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0008561C File Offset: 0x0008381C
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00005E0A File Offset: 0x0000400A
		public unsafe MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.ReconstructionFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_ReconstructionFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0008564C File Offset: 0x0008384C
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00005E29 File Offset: 0x00004029
		public unsafe MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurComponent.FrameBlendingFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FrameBlendingFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0008567C File Offset: 0x0008387C
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00005E48 File Offset: 0x00004048
		public unsafe bool m_FirstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.NativeFieldInfoPtr_m_FirstFrame)) = value;
			}
		}

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_m_ReconstructionFilter;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameBlendingFilter;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstFrame;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_reconstructionFilter_Public_get_ReconstructionFilter_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_frameBlendingFilter_Public_get_FrameBlendingFilter_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D1 RID: 2001
		public static class Uniforms : Object
		{
			// Token: 0x0600BB88 RID: 48008 RVA: 0x002E5950 File Offset: 0x002E3B50
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr);
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_VelocityScale");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_MaxBlurRadius");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_RcpMaxBlurRadius");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_VelocityTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_MainTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile2RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile4RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_Tile8RT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileMaxOffs");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileMaxLoop");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TileVRT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_NeighborMaxTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_LoopCount");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_TempRT");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4LumaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4ChromaTex");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History1Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History2Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History3Weight");
				MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.Uniforms>.NativeClassPtr, "_History4Weight");
			}

			// Token: 0x0600BB89 RID: 48009 RVA: 0x0005BBD4 File Offset: 0x00059DD4
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A04 RID: 14852
			// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x002E5B84 File Offset: 0x002E3D84
			// (set) Token: 0x0600BB8B RID: 48011 RVA: 0x0005BBDD File Offset: 0x00059DDD
			public unsafe static int _VelocityScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityScale, (void*)(&value));
				}
			}

			// Token: 0x17003A05 RID: 14853
			// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x002E5BA0 File Offset: 0x002E3DA0
			// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x0005BBEB File Offset: 0x00059DEB
			public unsafe static int _MaxBlurRadius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MaxBlurRadius, (void*)(&value));
				}
			}

			// Token: 0x17003A06 RID: 14854
			// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x002E5BBC File Offset: 0x002E3DBC
			// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x0005BBF9 File Offset: 0x00059DF9
			public unsafe static int _RcpMaxBlurRadius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__RcpMaxBlurRadius, (void*)(&value));
				}
			}

			// Token: 0x17003A07 RID: 14855
			// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x002E5BD8 File Offset: 0x002E3DD8
			// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x0005BC07 File Offset: 0x00059E07
			public unsafe static int _VelocityTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__VelocityTex, (void*)(&value));
				}
			}

			// Token: 0x17003A08 RID: 14856
			// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x002E5BF4 File Offset: 0x002E3DF4
			// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x0005BC15 File Offset: 0x00059E15
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x17003A09 RID: 14857
			// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x002E5C10 File Offset: 0x002E3E10
			// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x0005BC23 File Offset: 0x00059E23
			public unsafe static int _Tile2RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile2RT, (void*)(&value));
				}
			}

			// Token: 0x17003A0A RID: 14858
			// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x002E5C2C File Offset: 0x002E3E2C
			// (set) Token: 0x0600BB97 RID: 48023 RVA: 0x0005BC31 File Offset: 0x00059E31
			public unsafe static int _Tile4RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile4RT, (void*)(&value));
				}
			}

			// Token: 0x17003A0B RID: 14859
			// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x002E5C48 File Offset: 0x002E3E48
			// (set) Token: 0x0600BB99 RID: 48025 RVA: 0x0005BC3F File Offset: 0x00059E3F
			public unsafe static int _Tile8RT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__Tile8RT, (void*)(&value));
				}
			}

			// Token: 0x17003A0C RID: 14860
			// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x002E5C64 File Offset: 0x002E3E64
			// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x0005BC4D File Offset: 0x00059E4D
			public unsafe static int _TileMaxOffs
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxOffs, (void*)(&value));
				}
			}

			// Token: 0x17003A0D RID: 14861
			// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x002E5C80 File Offset: 0x002E3E80
			// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x0005BC5B File Offset: 0x00059E5B
			public unsafe static int _TileMaxLoop
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileMaxLoop, (void*)(&value));
				}
			}

			// Token: 0x17003A0E RID: 14862
			// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x002E5C9C File Offset: 0x002E3E9C
			// (set) Token: 0x0600BB9F RID: 48031 RVA: 0x0005BC69 File Offset: 0x00059E69
			public unsafe static int _TileVRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TileVRT, (void*)(&value));
				}
			}

			// Token: 0x17003A0F RID: 14863
			// (get) Token: 0x0600BBA0 RID: 48032 RVA: 0x002E5CB8 File Offset: 0x002E3EB8
			// (set) Token: 0x0600BBA1 RID: 48033 RVA: 0x0005BC77 File Offset: 0x00059E77
			public unsafe static int _NeighborMaxTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__NeighborMaxTex, (void*)(&value));
				}
			}

			// Token: 0x17003A10 RID: 14864
			// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x002E5CD4 File Offset: 0x002E3ED4
			// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x0005BC85 File Offset: 0x00059E85
			public unsafe static int _LoopCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__LoopCount, (void*)(&value));
				}
			}

			// Token: 0x17003A11 RID: 14865
			// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x002E5CF0 File Offset: 0x002E3EF0
			// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x0005BC93 File Offset: 0x00059E93
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x17003A12 RID: 14866
			// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x002E5D0C File Offset: 0x002E3F0C
			// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x0005BCA1 File Offset: 0x00059EA1
			public unsafe static int _History1LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A13 RID: 14867
			// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x002E5D28 File Offset: 0x002E3F28
			// (set) Token: 0x0600BBA9 RID: 48041 RVA: 0x0005BCAF File Offset: 0x00059EAF
			public unsafe static int _History2LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A14 RID: 14868
			// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x002E5D44 File Offset: 0x002E3F44
			// (set) Token: 0x0600BBAB RID: 48043 RVA: 0x0005BCBD File Offset: 0x00059EBD
			public unsafe static int _History3LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A15 RID: 14869
			// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x002E5D60 File Offset: 0x002E3F60
			// (set) Token: 0x0600BBAD RID: 48045 RVA: 0x0005BCCB File Offset: 0x00059ECB
			public unsafe static int _History4LumaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4LumaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A16 RID: 14870
			// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x002E5D7C File Offset: 0x002E3F7C
			// (set) Token: 0x0600BBAF RID: 48047 RVA: 0x0005BCD9 File Offset: 0x00059ED9
			public unsafe static int _History1ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A17 RID: 14871
			// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x002E5D98 File Offset: 0x002E3F98
			// (set) Token: 0x0600BBB1 RID: 48049 RVA: 0x0005BCE7 File Offset: 0x00059EE7
			public unsafe static int _History2ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A18 RID: 14872
			// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x002E5DB4 File Offset: 0x002E3FB4
			// (set) Token: 0x0600BBB3 RID: 48051 RVA: 0x0005BCF5 File Offset: 0x00059EF5
			public unsafe static int _History3ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A19 RID: 14873
			// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x002E5DD0 File Offset: 0x002E3FD0
			// (set) Token: 0x0600BBB5 RID: 48053 RVA: 0x0005BD03 File Offset: 0x00059F03
			public unsafe static int _History4ChromaTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4ChromaTex, (void*)(&value));
				}
			}

			// Token: 0x17003A1A RID: 14874
			// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x002E5DEC File Offset: 0x002E3FEC
			// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x0005BD11 File Offset: 0x00059F11
			public unsafe static int _History1Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History1Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A1B RID: 14875
			// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x002E5E08 File Offset: 0x002E4008
			// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x0005BD1F File Offset: 0x00059F1F
			public unsafe static int _History2Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History2Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A1C RID: 14876
			// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x002E5E24 File Offset: 0x002E4024
			// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x0005BD2D File Offset: 0x00059F2D
			public unsafe static int _History3Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History3Weight, (void*)(&value));
				}
			}

			// Token: 0x17003A1D RID: 14877
			// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x002E5E40 File Offset: 0x002E4040
			// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x0005BD3B File Offset: 0x00059F3B
			public unsafe static int _History4Weight
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotionBlurComponent.Uniforms.NativeFieldInfoPtr__History4Weight, (void*)(&value));
				}
			}

			// Token: 0x04007E58 RID: 32344
			private static readonly IntPtr NativeFieldInfoPtr__VelocityScale;

			// Token: 0x04007E59 RID: 32345
			private static readonly IntPtr NativeFieldInfoPtr__MaxBlurRadius;

			// Token: 0x04007E5A RID: 32346
			private static readonly IntPtr NativeFieldInfoPtr__RcpMaxBlurRadius;

			// Token: 0x04007E5B RID: 32347
			private static readonly IntPtr NativeFieldInfoPtr__VelocityTex;

			// Token: 0x04007E5C RID: 32348
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E5D RID: 32349
			private static readonly IntPtr NativeFieldInfoPtr__Tile2RT;

			// Token: 0x04007E5E RID: 32350
			private static readonly IntPtr NativeFieldInfoPtr__Tile4RT;

			// Token: 0x04007E5F RID: 32351
			private static readonly IntPtr NativeFieldInfoPtr__Tile8RT;

			// Token: 0x04007E60 RID: 32352
			private static readonly IntPtr NativeFieldInfoPtr__TileMaxOffs;

			// Token: 0x04007E61 RID: 32353
			private static readonly IntPtr NativeFieldInfoPtr__TileMaxLoop;

			// Token: 0x04007E62 RID: 32354
			private static readonly IntPtr NativeFieldInfoPtr__TileVRT;

			// Token: 0x04007E63 RID: 32355
			private static readonly IntPtr NativeFieldInfoPtr__NeighborMaxTex;

			// Token: 0x04007E64 RID: 32356
			private static readonly IntPtr NativeFieldInfoPtr__LoopCount;

			// Token: 0x04007E65 RID: 32357
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;

			// Token: 0x04007E66 RID: 32358
			private static readonly IntPtr NativeFieldInfoPtr__History1LumaTex;

			// Token: 0x04007E67 RID: 32359
			private static readonly IntPtr NativeFieldInfoPtr__History2LumaTex;

			// Token: 0x04007E68 RID: 32360
			private static readonly IntPtr NativeFieldInfoPtr__History3LumaTex;

			// Token: 0x04007E69 RID: 32361
			private static readonly IntPtr NativeFieldInfoPtr__History4LumaTex;

			// Token: 0x04007E6A RID: 32362
			private static readonly IntPtr NativeFieldInfoPtr__History1ChromaTex;

			// Token: 0x04007E6B RID: 32363
			private static readonly IntPtr NativeFieldInfoPtr__History2ChromaTex;

			// Token: 0x04007E6C RID: 32364
			private static readonly IntPtr NativeFieldInfoPtr__History3ChromaTex;

			// Token: 0x04007E6D RID: 32365
			private static readonly IntPtr NativeFieldInfoPtr__History4ChromaTex;

			// Token: 0x04007E6E RID: 32366
			private static readonly IntPtr NativeFieldInfoPtr__History1Weight;

			// Token: 0x04007E6F RID: 32367
			private static readonly IntPtr NativeFieldInfoPtr__History2Weight;

			// Token: 0x04007E70 RID: 32368
			private static readonly IntPtr NativeFieldInfoPtr__History3Weight;

			// Token: 0x04007E71 RID: 32369
			private static readonly IntPtr NativeFieldInfoPtr__History4Weight;
		}

		// Token: 0x020007D2 RID: 2002
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04007E73 RID: 32371
			VelocitySetup,
			// Token: 0x04007E74 RID: 32372
			TileMax1,
			// Token: 0x04007E75 RID: 32373
			TileMax2,
			// Token: 0x04007E76 RID: 32374
			TileMaxV,
			// Token: 0x04007E77 RID: 32375
			NeighborMax,
			// Token: 0x04007E78 RID: 32376
			Reconstruction,
			// Token: 0x04007E79 RID: 32377
			FrameCompression,
			// Token: 0x04007E7A RID: 32378
			FrameBlendingChroma,
			// Token: 0x04007E7B RID: 32379
			FrameBlendingRaw
		}

		// Token: 0x020007D3 RID: 2003
		public class ReconstructionFilter : Object
		{
			// Token: 0x0600BBBE RID: 48062 RVA: 0x002E5E5C File Offset: 0x002E405C
			// Note: this type is marked as 'beforefieldinit'.
			static ReconstructionFilter()
			{
				Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "ReconstructionFilter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr);
				MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, "m_VectorRTFormat");
				MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, "m_PackedRTFormat");
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663991);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663992);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_IsSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663993);
				MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr, 100663994);
			}

			// Token: 0x0600BBBF RID: 48063 RVA: 0x002E5F00 File Offset: 0x002E4100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76987, XrefRangeEnd = 76989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReconstructionFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.ReconstructionFilter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBC0 RID: 48064 RVA: 0x002E5F3C File Offset: 0x002E413C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76989, XrefRangeEnd = 76990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckTextureFormatSupport()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBC1 RID: 48065 RVA: 0x002E5F70 File Offset: 0x002E4170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76990, XrefRangeEnd = 76991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsSupported()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_IsSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBC2 RID: 48066 RVA: 0x002E5FAC File Offset: 0x002E41AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 77076, RefRangeEnd = 77078, XrefRangeStart = 76991, XrefRangeEnd = 77076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &settings;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.ReconstructionFilter.NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBC3 RID: 48067 RVA: 0x0005BD49 File Offset: 0x00059F49
			public ReconstructionFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A1E RID: 14878
			// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x002E6040 File Offset: 0x002E4240
			// (set) Token: 0x0600BBC5 RID: 48069 RVA: 0x0005BD52 File Offset: 0x00059F52
			public unsafe RenderTextureFormat m_VectorRTFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_VectorRTFormat)) = value;
				}
			}

			// Token: 0x17003A1F RID: 14879
			// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x002E6068 File Offset: 0x002E4268
			// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x0005BD6D File Offset: 0x00059F6D
			public unsafe RenderTextureFormat m_PackedRTFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.ReconstructionFilter.NativeFieldInfoPtr_m_PackedRTFormat)) = value;
				}
			}

			// Token: 0x04007E7C RID: 32380
			private static readonly IntPtr NativeFieldInfoPtr_m_VectorRTFormat;

			// Token: 0x04007E7D RID: 32381
			private static readonly IntPtr NativeFieldInfoPtr_m_PackedRTFormat;

			// Token: 0x04007E7E RID: 32382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007E7F RID: 32383
			private static readonly IntPtr NativeMethodInfoPtr_CheckTextureFormatSupport_Private_Void_0;

			// Token: 0x04007E80 RID: 32384
			private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Public_Boolean_0;

			// Token: 0x04007E81 RID: 32385
			private static readonly IntPtr NativeMethodInfoPtr_ProcessImage_Public_Void_PostProcessingContext_CommandBuffer_byref_Settings_RenderTargetIdentifier_RenderTargetIdentifier_Material_0;
		}

		// Token: 0x020007D4 RID: 2004
		public class FrameBlendingFilter : Object
		{
			// Token: 0x0600BBC8 RID: 48072 RVA: 0x002E6090 File Offset: 0x002E4290
			// Note: this type is marked as 'beforefieldinit'.
			static FrameBlendingFilter()
			{
				Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent>.NativeClassPtr, "FrameBlendingFilter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr);
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_UseCompression");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_RawTextureFormat");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_FrameList");
				MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "m_LastFrameCount");
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663995);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663996);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663997);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663998);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100663999);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100664000);
				MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, 100664001);
			}

			// Token: 0x0600BBC9 RID: 48073 RVA: 0x002E6198 File Offset: 0x002E4398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77139, XrefRangeEnd = 77157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FrameBlendingFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCA RID: 48074 RVA: 0x002E61D4 File Offset: 0x002E43D4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 77169, RefRangeEnd = 77172, XrefRangeStart = 77157, XrefRangeEnd = 77169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCB RID: 48075 RVA: 0x002E6208 File Offset: 0x002E4408
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77176, RefRangeEnd = 77177, XrefRangeStart = 77172, XrefRangeEnd = 77176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCC RID: 48076 RVA: 0x002E6288 File Offset: 0x002E4488
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 77224, RefRangeEnd = 77226, XrefRangeStart = 77177, XrefRangeEnd = 77224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBCD RID: 48077 RVA: 0x002E6308 File Offset: 0x002E4508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77226, XrefRangeEnd = 77227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool CheckSupportCompression()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBCE RID: 48078 RVA: 0x002E6338 File Offset: 0x002E4538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77227, XrefRangeEnd = 77235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBCF RID: 48079 RVA: 0x002E6368 File Offset: 0x002E4568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77235, XrefRangeEnd = 77236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref offset;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MotionBlurComponent.FrameBlendingFilter.Frame(pointer);
			}

			// Token: 0x0600BBD0 RID: 48080 RVA: 0x0005BD88 File Offset: 0x00059F88
			public FrameBlendingFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A20 RID: 14880
			// (get) Token: 0x0600BBD1 RID: 48081 RVA: 0x002E63AC File Offset: 0x002E45AC
			// (set) Token: 0x0600BBD2 RID: 48082 RVA: 0x0005BD91 File Offset: 0x00059F91
			public unsafe bool m_UseCompression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_UseCompression)) = value;
				}
			}

			// Token: 0x17003A21 RID: 14881
			// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x002E63D4 File Offset: 0x002E45D4
			// (set) Token: 0x0600BBD4 RID: 48084 RVA: 0x0005BDAC File Offset: 0x00059FAC
			public unsafe RenderTextureFormat m_RawTextureFormat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_RawTextureFormat)) = value;
				}
			}

			// Token: 0x17003A22 RID: 14882
			// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x002E63FC File Offset: 0x002E45FC
			// (set) Token: 0x0600BBD6 RID: 48086 RVA: 0x0005BDC7 File Offset: 0x00059FC7
			public unsafe Il2CppReferenceArray<MotionBlurComponent.FrameBlendingFilter.Frame> m_FrameList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MotionBlurComponent.FrameBlendingFilter.Frame>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_FrameList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A23 RID: 14883
			// (get) Token: 0x0600BBD7 RID: 48087 RVA: 0x002E642C File Offset: 0x002E462C
			// (set) Token: 0x0600BBD8 RID: 48088 RVA: 0x0005BDE6 File Offset: 0x00059FE6
			public unsafe int m_LastFrameCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.NativeFieldInfoPtr_m_LastFrameCount)) = value;
				}
			}

			// Token: 0x04007E82 RID: 32386
			private static readonly IntPtr NativeFieldInfoPtr_m_UseCompression;

			// Token: 0x04007E83 RID: 32387
			private static readonly IntPtr NativeFieldInfoPtr_m_RawTextureFormat;

			// Token: 0x04007E84 RID: 32388
			private static readonly IntPtr NativeFieldInfoPtr_m_FrameList;

			// Token: 0x04007E85 RID: 32389
			private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameCount;

			// Token: 0x04007E86 RID: 32390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007E87 RID: 32391
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

			// Token: 0x04007E88 RID: 32392
			private static readonly IntPtr NativeMethodInfoPtr_PushFrame_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0;

			// Token: 0x04007E89 RID: 32393
			private static readonly IntPtr NativeMethodInfoPtr_BlendFrames_Public_Void_CommandBuffer_Single_RenderTargetIdentifier_RenderTargetIdentifier_Material_0;

			// Token: 0x04007E8A RID: 32394
			private static readonly IntPtr NativeMethodInfoPtr_CheckSupportCompression_Private_Static_Boolean_0;

			// Token: 0x04007E8B RID: 32395
			private static readonly IntPtr NativeMethodInfoPtr_GetPreferredRenderTextureFormat_Private_Static_RenderTextureFormat_0;

			// Token: 0x04007E8C RID: 32396
			private static readonly IntPtr NativeMethodInfoPtr_GetFrameRelative_Private_Frame_Int32_0;

			// Token: 0x02000C1D RID: 3101
			public sealed class Frame : ValueType
			{
				// Token: 0x0600E0A0 RID: 57504 RVA: 0x0034DB4C File Offset: 0x0034BD4C
				// Note: this type is marked as 'beforefieldinit'.
				static Frame()
				{
					Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter>.NativeClassPtr, "Frame");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "lumaTexture");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "chromaTexture");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "m_Time");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, "m_MRT");
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664002);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664003);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664004);
					MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr, 100664005);
				}

				// Token: 0x0600E0A1 RID: 57505 RVA: 0x0034DC18 File Offset: 0x0034BE18
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 77083, RefRangeEnd = 77087, XrefRangeStart = 77078, XrefRangeEnd = 77083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float CalculateWeight(float strength, float currentTime)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref strength;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E0A2 RID: 57506 RVA: 0x0034DC74 File Offset: 0x0034BE74
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 77098, RefRangeEnd = 77100, XrefRangeStart = 77087, XrefRangeEnd = 77098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Release()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0A3 RID: 57507 RVA: 0x0034DCAC File Offset: 0x0034BEAC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77125, RefRangeEnd = 77126, XrefRangeStart = 77100, XrefRangeEnd = 77125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0A4 RID: 57508 RVA: 0x0034DD30 File Offset: 0x0034BF30
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77138, RefRangeEnd = 77139, XrefRangeStart = 77126, XrefRangeEnd = 77138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurComponent.FrameBlendingFilter.Frame.NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E0A5 RID: 57509 RVA: 0x0006D835 File Offset: 0x0006BA35
				public Frame(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600E0A6 RID: 57510 RVA: 0x0006D83E File Offset: 0x0006BA3E
				public Frame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurComponent.FrameBlendingFilter.Frame>.NativeClassPtr))
				{
				}

				// Token: 0x1700458F RID: 17807
				// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x0034DDB0 File Offset: 0x0034BFB0
				// (set) Token: 0x0600E0A8 RID: 57512 RVA: 0x0006D850 File Offset: 0x0006BA50
				public unsafe RenderTexture lumaTexture
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_lumaTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004590 RID: 17808
				// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x0034DDE0 File Offset: 0x0034BFE0
				// (set) Token: 0x0600E0AA RID: 57514 RVA: 0x0006D86F File Offset: 0x0006BA6F
				public unsafe RenderTexture chromaTexture
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_chromaTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004591 RID: 17809
				// (get) Token: 0x0600E0AB RID: 57515 RVA: 0x0034DE10 File Offset: 0x0034C010
				// (set) Token: 0x0600E0AC RID: 57516 RVA: 0x0006D88E File Offset: 0x0006BA8E
				public unsafe float m_Time
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_Time)) = value;
					}
				}

				// Token: 0x17004592 RID: 17810
				// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x0034DE38 File Offset: 0x0034C038
				// (set) Token: 0x0600E0AE RID: 57518 RVA: 0x0006D8A9 File Offset: 0x0006BAA9
				public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurComponent.FrameBlendingFilter.Frame.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009664 RID: 38500
				private static readonly IntPtr NativeFieldInfoPtr_lumaTexture;

				// Token: 0x04009665 RID: 38501
				private static readonly IntPtr NativeFieldInfoPtr_chromaTexture;

				// Token: 0x04009666 RID: 38502
				private static readonly IntPtr NativeFieldInfoPtr_m_Time;

				// Token: 0x04009667 RID: 38503
				private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

				// Token: 0x04009668 RID: 38504
				private static readonly IntPtr NativeMethodInfoPtr_CalculateWeight_Public_Single_Single_Single_0;

				// Token: 0x04009669 RID: 38505
				private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

				// Token: 0x0400966A RID: 38506
				private static readonly IntPtr NativeMethodInfoPtr_MakeRecord_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_Material_0;

				// Token: 0x0400966B RID: 38507
				private static readonly IntPtr NativeMethodInfoPtr_MakeRecordRaw_Public_Void_CommandBuffer_RenderTargetIdentifier_Int32_Int32_RenderTextureFormat_0;
			}
		}
	}
}
