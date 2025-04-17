using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BC RID: 444
	public class Quest_GearingUp : Quest
	{
		// Token: 0x06002646 RID: 9798 RVA: 0x000E8A94 File Offset: 0x000E6C94
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GearingUp()
		{
			Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GearingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr);
			Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "WaitForDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "CollectDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "Supplier");
			Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "setCollectionPosition");
			Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667578);
			Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667579);
			Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667580);
			Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667581);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000E8B64 File Offset: 0x000E6D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116809, XrefRangeEnd = 116818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000E8BA0 File Offset: 0x000E6DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116818, XrefRangeEnd = 116853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000E8BDC File Offset: 0x000E6DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116853, XrefRangeEnd = 116854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000E8C10 File Offset: 0x000E6E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116854, XrefRangeEnd = 116858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GearingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000153A7 File Offset: 0x000135A7
		public Quest_GearingUp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000E8C4C File Offset: 0x000E6E4C
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x000153B0 File Offset: 0x000135B0
		public unsafe QuestEntry WaitForDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000E8C7C File Offset: 0x000E6E7C
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x000153CF File Offset: 0x000135CF
		public unsafe QuestEntry CollectDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000E8CAC File Offset: 0x000E6EAC
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x000153EE File Offset: 0x000135EE
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x000E8CDC File Offset: 0x000E6EDC
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x0001540D File Offset: 0x0001360D
		public unsafe bool setCollectionPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition)) = value;
			}
		}

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeFieldInfoPtr_WaitForDropEntry;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_CollectDropEntry;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_setCollectionPosition;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_DropReady_Private_Void_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D1 RID: 2257
		[ObfuscatedName("ScheduleOne.Quests.Quest_GearingUp+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600C40B RID: 50187 RVA: 0x002FC5E0 File Offset: 0x002FA7E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr);
				Quest_GearingUp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9");
				Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9__5_0");
				Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667583);
				Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667584);
			}

			// Token: 0x0600C40C RID: 50188 RVA: 0x002FC65C File Offset: 0x002FA85C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C40D RID: 50189 RVA: 0x002FC698 File Offset: 0x002FA898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116808, XrefRangeEnd = 116809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MinPass_b__5_0(DeadDrop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C40E RID: 50190 RVA: 0x0005F6CA File Offset: 0x0005D8CA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D31 RID: 15665
			// (get) Token: 0x0600C40F RID: 50191 RVA: 0x002FC6E8 File Offset: 0x002FA8E8
			// (set) Token: 0x0600C410 RID: 50192 RVA: 0x0005F6D3 File Offset: 0x0005D8D3
			public unsafe static Quest_GearingUp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_GearingUp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D32 RID: 15666
			// (get) Token: 0x0600C411 RID: 50193 RVA: 0x002FC710 File Offset: 0x002FA910
			// (set) Token: 0x0600C412 RID: 50194 RVA: 0x0005F6E5 File Offset: 0x0005D8E5
			public unsafe static Predicate<DeadDrop> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DeadDrop>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084E0 RID: 34016
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084E1 RID: 34017
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040084E2 RID: 34018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084E3 RID: 34019
			private static readonly IntPtr NativeMethodInfoPtr__MinPass_b__5_0_Internal_Boolean_DeadDrop_0;
		}
	}
}
