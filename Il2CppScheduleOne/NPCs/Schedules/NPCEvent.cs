using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E5 RID: 741
	public class NPCEvent : NPCAction
	{
		// Token: 0x06003785 RID: 14213 RVA: 0x00124174 File Offset: 0x00122374
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent()
		{
			Il2CppClassPointerStore<NPCEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr);
			NPCEvent.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, "Duration");
			NPCEvent.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, "EndTime");
			NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted");
			NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted");
			NPCEvent.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669679);
			NPCEvent.NativeMethodInfoPtr_ApplyDuration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669680);
			NPCEvent.NativeMethodInfoPtr_ApplyEndTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669681);
			NPCEvent.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669682);
			NPCEvent.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669683);
			NPCEvent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669684);
			NPCEvent.NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669685);
			NPCEvent.NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669686);
			NPCEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669687);
			NPCEvent.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669688);
			NPCEvent.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669689);
			NPCEvent.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669690);
			NPCEvent.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr, 100669691);
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x001242F8 File Offset: 0x001224F8
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140526, XrefRangeEnd = 140528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00124330 File Offset: 0x00122530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140528, XrefRangeEnd = 140540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent.NativeMethodInfoPtr_ApplyDuration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00124364 File Offset: 0x00122564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140540, XrefRangeEnd = 140559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent.NativeMethodInfoPtr_ApplyEndTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00124398 File Offset: 0x00122598
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140563, RefRangeEnd = 140567, XrefRangeStart = 140559, XrefRangeEnd = 140563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x001243D4 File Offset: 0x001225D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PendingMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00124410 File Offset: 0x00122610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00124454 File Offset: 0x00122654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140567, XrefRangeEnd = 140572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetTimeDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00124498 File Offset: 0x00122698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140572, XrefRangeEnd = 140573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x001244E0 File Offset: 0x001226E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140574, RefRangeEnd = 140579, XrefRangeStart = 140573, XrefRangeEnd = 140574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0012451C File Offset: 0x0012271C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140579, RefRangeEnd = 140584, XrefRangeStart = 140579, XrefRangeEnd = 140579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00124558 File Offset: 0x00122758
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140584, RefRangeEnd = 140589, XrefRangeStart = 140584, XrefRangeEnd = 140584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00124594 File Offset: 0x00122794
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x001245D0 File Offset: 0x001227D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140590, RefRangeEnd = 140594, XrefRangeStart = 140589, XrefRangeEnd = 140590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0001CDDD File Offset: 0x0001AFDD
		public NPCEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x0012460C File Offset: 0x0012280C
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x0001CDE6 File Offset: 0x0001AFE6
		public unsafe int Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x00124634 File Offset: 0x00122834
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x0001CE01 File Offset: 0x0001B001
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x0012465C File Offset: 0x0012285C
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x0001CE1C File Offset: 0x0001B01C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x00124684 File Offset: 0x00122884
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x0001CE37 File Offset: 0x0001B037
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDuration_Public_Void_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEndTime_Public_Void_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_Void_0;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
