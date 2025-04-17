using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000458 RID: 1112
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x0600609B RID: 24731 RVA: 0x001B9A18 File Offset: 0x001B7C18
		// Note: this type is marked as 'beforefieldinit'.
		static LightOptimizer()
		{
			Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LightOptimizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr);
			LightOptimizer.NativeFieldInfoPtr_LightsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "LightsEnabled");
			LightOptimizer.NativeFieldInfoPtr_activationZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "activationZones");
			LightOptimizer.NativeFieldInfoPtr_viewPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "viewPoints");
			LightOptimizer.NativeFieldInfoPtr_checkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "checkRange");
			LightOptimizer.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "lights");
			LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675589);
			LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675590);
			LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675591);
			LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675592);
			LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675593);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675594);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675595);
			LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675596);
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x001B9B4C File Offset: 0x001B7D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199332, XrefRangeEnd = 199336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x001B9B80 File Offset: 0x001B7D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199336, XrefRangeEnd = 199361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x001B9BB4 File Offset: 0x001B7DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199362, RefRangeEnd = 199363, XrefRangeStart = 199361, XrefRangeEnd = 199362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x001B9BE8 File Offset: 0x001B7DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199363, XrefRangeEnd = 199389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x001B9C34 File Offset: 0x001B7E34
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x001B9C80 File Offset: 0x001B7E80
		[CallerCount(0)]
		public unsafe void LightsEnabled_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x001B9CB4 File Offset: 0x001B7EB4
		[CallerCount(0)]
		public unsafe void LightsEnabled_False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x001B9CE8 File Offset: 0x001B7EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199389, XrefRangeEnd = 199390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightOptimizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x0002DAF7 File Offset: 0x0002BCF7
		public LightOptimizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x060060A5 RID: 24741 RVA: 0x001B9D24 File Offset: 0x001B7F24
		// (set) Token: 0x060060A6 RID: 24742 RVA: 0x0002DB00 File Offset: 0x0002BD00
		public unsafe bool LightsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled)) = value;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x060060A7 RID: 24743 RVA: 0x001B9D4C File Offset: 0x001B7F4C
		// (set) Token: 0x060060A8 RID: 24744 RVA: 0x0002DB1B File Offset: 0x0002BD1B
		public unsafe Il2CppReferenceArray<BoxCollider> activationZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x001B9D7C File Offset: 0x001B7F7C
		// (set) Token: 0x060060AA RID: 24746 RVA: 0x0002DB3A File Offset: 0x0002BD3A
		public unsafe Il2CppReferenceArray<Transform> viewPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x060060AB RID: 24747 RVA: 0x001B9DAC File Offset: 0x001B7FAC
		// (set) Token: 0x060060AC RID: 24748 RVA: 0x0002DB59 File Offset: 0x0002BD59
		public unsafe float checkRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange)) = value;
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x060060AD RID: 24749 RVA: 0x001B9DD4 File Offset: 0x001B7FD4
		// (set) Token: 0x060060AE RID: 24750 RVA: 0x0002DB74 File Offset: 0x0002BD74
		public unsafe Il2CppReferenceArray<OptimizedLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041F1 RID: 16881
		private static readonly IntPtr NativeFieldInfoPtr_LightsEnabled;

		// Token: 0x040041F2 RID: 16882
		private static readonly IntPtr NativeFieldInfoPtr_activationZones;

		// Token: 0x040041F3 RID: 16883
		private static readonly IntPtr NativeFieldInfoPtr_viewPoints;

		// Token: 0x040041F4 RID: 16884
		private static readonly IntPtr NativeFieldInfoPtr_checkRange;

		// Token: 0x040041F5 RID: 16885
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x040041F6 RID: 16886
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040041F7 RID: 16887
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040041F8 RID: 16888
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLights_Public_Void_0;

		// Token: 0x040041F9 RID: 16889
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x040041FA RID: 16890
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x040041FB RID: 16891
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0;

		// Token: 0x040041FC RID: 16892
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0;

		// Token: 0x040041FD RID: 16893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
