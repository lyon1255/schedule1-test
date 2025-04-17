using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B5 RID: 949
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x060049F4 RID: 18932 RVA: 0x001678CC File Offset: 0x00165ACC
		// Note: this type is marked as 'beforefieldinit'.
		static LightExposureNode()
		{
			Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightExposureNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr);
			LightExposureNode.NativeFieldInfoPtr_ambientExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "ambientExposure");
			LightExposureNode.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "sources");
			LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672472);
			LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672473);
			LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672474);
			LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672475);
			LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672476);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00167988 File Offset: 0x00165B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163627, RefRangeEnd = 163629, XrefRangeStart = 163603, XrefRangeEnd = 163627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x001679D4 File Offset: 0x00165BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163639, RefRangeEnd = 163640, XrefRangeStart = 163629, XrefRangeEnd = 163639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSource(UsableLightSource source, float lightAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x00167A24 File Offset: 0x00165C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163644, RefRangeEnd = 163645, XrefRangeStart = 163640, XrefRangeEnd = 163644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSource(UsableLightSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00167A68 File Offset: 0x00165C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163645, XrefRangeEnd = 163650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00167A9C File Offset: 0x00165C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163650, XrefRangeEnd = 163658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightExposureNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00023A1E File Offset: 0x00021C1E
		public LightExposureNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x00167AD8 File Offset: 0x00165CD8
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x00023A27 File Offset: 0x00021C27
		public unsafe float ambientExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure)) = value;
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x00167B00 File Offset: 0x00165D00
		// (set) Token: 0x060049FE RID: 18942 RVA: 0x00023A42 File Offset: 0x00021C42
		public unsafe Dictionary<UsableLightSource, float> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UsableLightSource, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeFieldInfoPtr_ambientExposure;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
