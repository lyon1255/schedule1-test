using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DC RID: 988
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x06004C79 RID: 19577 RVA: 0x0016F9B4 File Offset: 0x0016DBB4
		// Note: this type is marked as 'beforefieldinit'.
		static SentryLocation()
		{
			Il2CppClassPointerStore<SentryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr);
			SentryLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "StandPoints");
			SentryLocation.NativeFieldInfoPtr_AssignedOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, "AssignedOfficers");
			SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr, 100672740);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x0016FA20 File Offset: 0x0016DC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165637, XrefRangeEnd = 165652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00024C42 File Offset: 0x00022E42
		public SentryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x0016FA5C File Offset: 0x0016DC5C
		// (set) Token: 0x06004C7D RID: 19581 RVA: 0x00024C4B File Offset: 0x00022E4B
		public unsafe List<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x0016FA8C File Offset: 0x0016DC8C
		// (set) Token: 0x06004C7F RID: 19583 RVA: 0x00024C6A File Offset: 0x00022E6A
		public unsafe List<PoliceOfficer> AssignedOfficers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryLocation.NativeFieldInfoPtr_AssignedOfficers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeFieldInfoPtr_AssignedOfficers;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
