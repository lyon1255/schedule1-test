using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000548 RID: 1352
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x0600778E RID: 30606 RVA: 0x002067B4 File Offset: 0x002049B4
		// Note: this type is marked as 'beforefieldinit'.
		static RandomIntervalEvent()
		{
			Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RandomIntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr);
			RandomIntervalEvent.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MinInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MaxInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "ExecuteOnEnable");
			RandomIntervalEvent.NativeFieldInfoPtr_OnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "OnInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_nextInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "nextInterval");
			RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678352);
			RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678353);
			RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678354);
			RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678355);
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00206898 File Offset: 0x00204A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231814, XrefRangeEnd = 231819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x002068CC File Offset: 0x00204ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231819, XrefRangeEnd = 231823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00206900 File Offset: 0x00204B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231823, XrefRangeEnd = 231826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00206934 File Offset: 0x00204B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231826, XrefRangeEnd = 231827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomIntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x000389D2 File Offset: 0x00036BD2
		public RandomIntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x00206970 File Offset: 0x00204B70
		// (set) Token: 0x06007795 RID: 30613 RVA: 0x000389DB File Offset: 0x00036BDB
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x00206998 File Offset: 0x00204B98
		// (set) Token: 0x06007797 RID: 30615 RVA: 0x000389F6 File Offset: 0x00036BF6
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x002069C0 File Offset: 0x00204BC0
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x00038A11 File Offset: 0x00036C11
		public unsafe bool ExecuteOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable)) = value;
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x002069E8 File Offset: 0x00204BE8
		// (set) Token: 0x0600779B RID: 30619 RVA: 0x00038A2C File Offset: 0x00036C2C
		public unsafe UnityEvent OnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x00206A18 File Offset: 0x00204C18
		// (set) Token: 0x0600779D RID: 30621 RVA: 0x00038A4B File Offset: 0x00036C4B
		public unsafe float nextInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval)) = value;
			}
		}

		// Token: 0x04005195 RID: 20885
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04005196 RID: 20886
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04005197 RID: 20887
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteOnEnable;

		// Token: 0x04005198 RID: 20888
		private static readonly IntPtr NativeFieldInfoPtr_OnInterval;

		// Token: 0x04005199 RID: 20889
		private static readonly IntPtr NativeFieldInfoPtr_nextInterval;

		// Token: 0x0400519A RID: 20890
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400519B RID: 20891
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400519C RID: 20892
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x0400519D RID: 20893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
