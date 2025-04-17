using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000315 RID: 789
	public class Jeremy : NPC
	{
		// Token: 0x06003AC9 RID: 15049 RVA: 0x0012F93C File Offset: 0x0012DB3C
		// Note: this type is marked as 'beforefieldinit'.
		static Jeremy()
		{
			Il2CppClassPointerStore<Jeremy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Jeremy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy>.NativeClassPtr);
			Jeremy.NativeFieldInfoPtr_Dealership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Dealership");
			Jeremy.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Listings");
			Jeremy.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetingDialogue");
			Jeremy.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetedVariable");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670143);
			Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670144);
			Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670145);
			Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670146);
			Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670147);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670148);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670149);
			Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670150);
			Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100670151);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x0012FA98 File Offset: 0x0012DC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142259, XrefRangeEnd = 142272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x0012FAD4 File Offset: 0x0012DCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142272, XrefRangeEnd = 142301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x0012FB08 File Offset: 0x0012DD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142301, XrefRangeEnd = 142313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x0012FB3C File Offset: 0x0012DD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142313, XrefRangeEnd = 142333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x0012FB70 File Offset: 0x0012DD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142333, XrefRangeEnd = 142345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jeremy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x0012FBAC File Offset: 0x0012DDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142345, XrefRangeEnd = 142346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x0012FBE8 File Offset: 0x0012DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142346, XrefRangeEnd = 142347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x0012FC24 File Offset: 0x0012DE24
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0012FC60 File Offset: 0x0012DE60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x0001DFD3 File Offset: 0x0001C1D3
		public Jeremy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x0012FC9C File Offset: 0x0012DE9C
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x0001DFDC File Offset: 0x0001C1DC
		public unsafe Dealership Dealership
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealership>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x0012FCCC File Offset: 0x0012DECC
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x0001DFFB File Offset: 0x0001C1FB
		public unsafe List<Jeremy.DealershipListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Jeremy.DealershipListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x0012FCFC File Offset: 0x0012DEFC
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x0001E01A File Offset: 0x0001C21A
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x0012FD2C File Offset: 0x0012DF2C
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x0001E039 File Offset: 0x0001C239
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x0012FD54 File Offset: 0x0012DF54
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x0001E058 File Offset: 0x0001C258
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x0012FD7C File Offset: 0x0012DF7C
		// (set) Token: 0x06003ADF RID: 15071 RVA: 0x0001E073 File Offset: 0x0001C273
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeFieldInfoPtr_Dealership;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200093B RID: 2363
		[Serializable]
		public class DealershipListing : Object
		{
			// Token: 0x0600C73C RID: 51004 RVA: 0x0030570C File Offset: 0x0030390C
			// Note: this type is marked as 'beforefieldinit'.
			static DealershipListing()
			{
				Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "DealershipListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr);
				Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, "vehicleCode");
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670152);
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670153);
				Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100670154);
			}

			// Token: 0x17003E15 RID: 15893
			// (get) Token: 0x0600C73D RID: 51005 RVA: 0x00305788 File Offset: 0x00303988
			public unsafe string vehicleName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 142246, RefRangeEnd = 142247, XrefRangeStart = 142241, XrefRangeEnd = 142246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003E16 RID: 15894
			// (get) Token: 0x0600C73E RID: 51006 RVA: 0x003057C0 File Offset: 0x003039C0
			public unsafe float price
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 142252, RefRangeEnd = 142255, XrefRangeStart = 142247, XrefRangeEnd = 142252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C73F RID: 51007 RVA: 0x003057FC File Offset: 0x003039FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142255, XrefRangeEnd = 142259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DealershipListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C740 RID: 51008 RVA: 0x00060F5C File Offset: 0x0005F15C
			public DealershipListing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E14 RID: 15892
			// (get) Token: 0x0600C741 RID: 51009 RVA: 0x00305838 File Offset: 0x00303A38
			// (set) Token: 0x0600C742 RID: 51010 RVA: 0x00060F65 File Offset: 0x0005F165
			public unsafe string vehicleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040086DC RID: 34524
			private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x040086DD RID: 34525
			private static readonly IntPtr NativeMethodInfoPtr_get_vehicleName_Public_get_String_0;

			// Token: 0x040086DE RID: 34526
			private static readonly IntPtr NativeMethodInfoPtr_get_price_Public_get_Single_0;

			// Token: 0x040086DF RID: 34527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
