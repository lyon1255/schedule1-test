using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C5 RID: 453
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x060026B8 RID: 9912 RVA: 0x000E9FA4 File Offset: 0x000E81A4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_UnfavourableAgreements()
		{
			Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_UnfavourableAgreements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr);
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "WEEKLY_DELIVERY_HOURS");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "REMINDER_THRESHOLD");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Thomas");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Gate");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "Switch");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "RV");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "QuestEntryTitle");
			Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, "handoverSetup");
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667628);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667629);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667630);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667631);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667632);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667633);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667634);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667635);
			Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr, 100667636);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000EA128 File Offset: 0x000E8328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117334, XrefRangeEnd = 117371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000EA164 File Offset: 0x000E8364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117371, XrefRangeEnd = 117373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_UnfavourableAgreements.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000EA1B0 File Offset: 0x000E83B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117373, XrefRangeEnd = 117415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000EA1E4 File Offset: 0x000E83E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117415, XrefRangeEnd = 117425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupHandover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_SetupHandover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000EA218 File Offset: 0x000E8418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117425, XrefRangeEnd = 117448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHandoverExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000EA24C File Offset: 0x000E844C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117484, RefRangeEnd = 117487, XrefRangeStart = 117448, XrefRangeEnd = 117484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000EA280 File Offset: 0x000E8480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117487, XrefRangeEnd = 117488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_HandoverCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000EA2B4 File Offset: 0x000E84B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117517, RefRangeEnd = 117520, XrefRangeStart = 117488, XrefRangeEnd = 117517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTimer(bool allowBuildup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowBuildup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000EA2F4 File Offset: 0x000E84F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117520, XrefRangeEnd = 117524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_UnfavourableAgreements() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_UnfavourableAgreements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_UnfavourableAgreements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00015730 File Offset: 0x00013930
		public Quest_UnfavourableAgreements(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000EA330 File Offset: 0x000E8530
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00015739 File Offset: 0x00013939
		public unsafe static float WEEKLY_DELIVERY_HOURS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000EA34C File Offset: 0x000E854C
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00015747 File Offset: 0x00013947
		public unsafe static float REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_UnfavourableAgreements.NativeFieldInfoPtr_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000EA368 File Offset: 0x000E8568
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x00015755 File Offset: 0x00013955
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000EA398 File Offset: 0x000E8598
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x00015774 File Offset: 0x00013974
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000EA3C8 File Offset: 0x000E85C8
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00015793 File Offset: 0x00013993
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000EA3F8 File Offset: 0x000E85F8
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x000157B2 File Offset: 0x000139B2
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000EA428 File Offset: 0x000E8628
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x000157D1 File Offset: 0x000139D1
		public unsafe string QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000EA450 File Offset: 0x000E8650
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x000157F0 File Offset: 0x000139F0
		public unsafe bool handoverSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_UnfavourableAgreements.NativeFieldInfoPtr_handoverSetup)) = value;
			}
		}

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeFieldInfoPtr_WEEKLY_DELIVERY_HOURS;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeFieldInfoPtr_REMINDER_THRESHOLD;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeFieldInfoPtr_handoverSetup;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_SetupHandover_Private_Void_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_CheckHandoverExpiry_Private_Void_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_HandoverCompleted_Private_Void_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_ResetTimer_Public_Void_Boolean_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
