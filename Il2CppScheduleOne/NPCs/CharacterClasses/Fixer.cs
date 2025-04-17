using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000305 RID: 773
	public class Fixer : NPC
	{
		// Token: 0x06003A02 RID: 14850 RVA: 0x0012D1F0 File Offset: 0x0012B3F0
		// Note: this type is marked as 'beforefieldinit'.
		static Fixer()
		{
			Il2CppClassPointerStore<Fixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Fixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fixer>.NativeClassPtr);
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_1");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_SIGNING_FEE_2");
			Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "MAX_SIGNING_FEE");
			Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "ADDITIONAL_FEE_THRESHOLD");
			Fixer.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetingDialogue");
			Fixer.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "GreetedVariable");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fixer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted");
			Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670056);
			Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670057);
			Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670058);
			Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670059);
			Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670060);
			Fixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670061);
			Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670062);
			Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670063);
			Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670064);
			Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fixer>.NativeClassPtr, 100670065);
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0012D388 File Offset: 0x0012B588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142106, XrefRangeEnd = 142119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x0012D3C4 File Offset: 0x0012B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142119, XrefRangeEnd = 142148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x0012D3F8 File Offset: 0x0012B5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142148, XrefRangeEnd = 142160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0012D42C File Offset: 0x0012B62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142160, XrefRangeEnd = 142180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x0012D460 File Offset: 0x0012B660
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142208, RefRangeEnd = 142211, XrefRangeStart = 142180, XrefRangeEnd = 142208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAdditionalSigningFee()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x0012D490 File Offset: 0x0012B690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142211, XrefRangeEnd = 142216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fixer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x0012D4CC File Offset: 0x0012B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x0012D508 File Offset: 0x0012B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0012D544 File Offset: 0x0012B744
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x0012D580 File Offset: 0x0012B780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Fixer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x0001DB2F File Offset: 0x0001BD2F
		public Fixer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x0012D5BC File Offset: 0x0012B7BC
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x0001DB38 File Offset: 0x0001BD38
		public unsafe static int ADDITIONAL_SIGNING_FEE_1
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1, (void*)(&value));
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x0012D5D8 File Offset: 0x0012B7D8
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x0001DB46 File Offset: 0x0001BD46
		public unsafe static int ADDITIONAL_SIGNING_FEE_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2, (void*)(&value));
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x0012D5F4 File Offset: 0x0012B7F4
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x0001DB54 File Offset: 0x0001BD54
		public unsafe static int MAX_SIGNING_FEE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_MAX_SIGNING_FEE, (void*)(&value));
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0012D610 File Offset: 0x0012B810
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x0001DB62 File Offset: 0x0001BD62
		public unsafe static int ADDITIONAL_FEE_THRESHOLD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Fixer.NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x0012D62C File Offset: 0x0012B82C
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x0001DB70 File Offset: 0x0001BD70
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x0012D65C File Offset: 0x0012B85C
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x0001DB8F File Offset: 0x0001BD8F
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x0012D684 File Offset: 0x0012B884
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0001DBAE File Offset: 0x0001BDAE
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x0001DBC9 File Offset: 0x0001BDC9
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fixer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_1;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_SIGNING_FEE_2;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SIGNING_FEE;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIONAL_FEE_THRESHOLD;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalSigningFee_Public_Static_Single_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
