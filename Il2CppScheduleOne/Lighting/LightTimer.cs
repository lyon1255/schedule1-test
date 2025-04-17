using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B6 RID: 950
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x060049FF RID: 18943 RVA: 0x00167B30 File Offset: 0x00165D30
		// Note: this type is marked as 'beforefieldinit'.
		static LightTimer()
		{
			Il2CppClassPointerStore<LightTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightTimer>.NativeClassPtr);
			LightTimer.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTime");
			LightTimer.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "EndTime");
			LightTimer.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTimeOffset");
			LightTimer.NativeFieldInfoPtr_toggleableLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "toggleableLight");
			LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672477);
			LightTimer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672478);
			LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672479);
			LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672480);
			LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672481);
			LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100672482);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00167C28 File Offset: 0x00165E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163658, XrefRangeEnd = 163678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00167C64 File Offset: 0x00165E64
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00167C98 File Offset: 0x00165E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163678, XrefRangeEnd = 163683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00167CD4 File Offset: 0x00165ED4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00167D08 File Offset: 0x00165F08
		[CallerCount(0)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00167D48 File Offset: 0x00165F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightTimer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00023A61 File Offset: 0x00021C61
		public LightTimer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00167D84 File Offset: 0x00165F84
		// (set) Token: 0x06004A08 RID: 18952 RVA: 0x00023A6A File Offset: 0x00021C6A
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06004A09 RID: 18953 RVA: 0x00167DAC File Offset: 0x00165FAC
		// (set) Token: 0x06004A0A RID: 18954 RVA: 0x00023A85 File Offset: 0x00021C85
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x00167DD4 File Offset: 0x00165FD4
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x00023AA0 File Offset: 0x00021CA0
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00167DFC File Offset: 0x00165FFC
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x00023ABB File Offset: 0x00021CBB
		public unsafe ToggleableLight toggleableLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr_toggleableLight;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
