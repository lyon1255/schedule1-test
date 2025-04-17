using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E6 RID: 742
	public class NPCSignal : NPCAction
	{
		// Token: 0x0600379C RID: 14236 RVA: 0x001246AC File Offset: 0x001228AC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSignal()
		{
			Il2CppClassPointerStore<NPCSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCSignal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr);
			NPCSignal.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, "MaxDuration");
			NPCSignal.NativeFieldInfoPtr__StartedThisCycle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, "<StartedThisCycle>k__BackingField");
			NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted");
			NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted");
			NPCSignal.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669692);
			NPCSignal.NativeMethodInfoPtr_get_StartedThisCycle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669693);
			NPCSignal.NativeMethodInfoPtr_set_StartedThisCycle_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669694);
			NPCSignal.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669695);
			NPCSignal.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669696);
			NPCSignal.NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669697);
			NPCSignal.NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669698);
			NPCSignal.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669699);
			NPCSignal.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669700);
			NPCSignal.NativeMethodInfoPtr_ShouldStart_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669701);
			NPCSignal.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669702);
			NPCSignal.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669703);
			NPCSignal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669704);
			NPCSignal.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669705);
			NPCSignal.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669706);
			NPCSignal.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669707);
			NPCSignal.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr, 100669708);
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x00124880 File Offset: 0x00122A80
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140594, XrefRangeEnd = 140596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x001248B8 File Offset: 0x00122AB8
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x001248F4 File Offset: 0x00122AF4
		public unsafe bool StartedThisCycle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal.NativeMethodInfoPtr_get_StartedThisCycle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 140596, RefRangeEnd = 140597, XrefRangeStart = 140596, XrefRangeEnd = 140596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal.NativeMethodInfoPtr_set_StartedThisCycle_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00124934 File Offset: 0x00122B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00124978 File Offset: 0x00122B78
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x001249B4 File Offset: 0x00122BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140597, XrefRangeEnd = 140598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetTimeDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x001249F8 File Offset: 0x00122BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00124A40 File Offset: 0x00122C40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 140607, RefRangeEnd = 140613, XrefRangeStart = 140598, XrefRangeEnd = 140607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00124A7C File Offset: 0x00122C7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 140622, RefRangeEnd = 140628, XrefRangeStart = 140613, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00124AB8 File Offset: 0x00122CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140628, XrefRangeEnd = 140630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_ShouldStart_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00124B00 File Offset: 0x00122D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140630, XrefRangeEnd = 140631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00124B3C File Offset: 0x00122D3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140636, RefRangeEnd = 140639, XrefRangeStart = 140631, XrefRangeEnd = 140636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00124B78 File Offset: 0x00122D78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140574, RefRangeEnd = 140579, XrefRangeStart = 140574, XrefRangeEnd = 140579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSignal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00124BB4 File Offset: 0x00122DB4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00124BF0 File Offset: 0x00122DF0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00124C2C File Offset: 0x00122E2C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00124C68 File Offset: 0x00122E68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140590, RefRangeEnd = 140594, XrefRangeStart = 140590, XrefRangeEnd = 140594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0001CE52 File Offset: 0x0001B052
		public NPCSignal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x00124CA4 File Offset: 0x00122EA4
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0001CE5B File Offset: 0x0001B05B
		public unsafe int MaxDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_MaxDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_MaxDuration)) = value;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x00124CCC File Offset: 0x00122ECC
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0001CE76 File Offset: 0x0001B076
		public unsafe bool _StartedThisCycle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr__StartedThisCycle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr__StartedThisCycle_k__BackingField)) = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x00124CF4 File Offset: 0x00122EF4
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x0001CE91 File Offset: 0x0001B091
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x00124D1C File Offset: 0x00122F1C
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeFieldInfoPtr_MaxDuration;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeFieldInfoPtr__StartedThisCycle_k__BackingField;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_get_StartedThisCycle_Public_get_Boolean_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_set_StartedThisCycle_Protected_set_Void_Boolean_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeDescription_Public_Virtual_String_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_GetEndTime_Public_Virtual_Int32_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStart_Public_Virtual_Boolean_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
