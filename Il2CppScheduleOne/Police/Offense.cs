using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001F9 RID: 505
	public class Offense : Object
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x000F1998 File Offset: 0x000EFB98
		// Note: this type is marked as 'beforefieldinit'.
		static Offense()
		{
			Il2CppClassPointerStore<Offense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Offense");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense>.NativeClassPtr);
			Offense.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "charges");
			Offense.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "penalties");
			Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense>.NativeClassPtr, 100667905);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000F1A04 File Offset: 0x000EFC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118867, XrefRangeEnd = 118886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Offense(List<Offense.Charge> _charges) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_charges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000161FB File Offset: 0x000143FB
		public Offense(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000F1A50 File Offset: 0x000EFC50
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x00016204 File Offset: 0x00014404
		public unsafe List<Offense.Charge> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Offense.Charge>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000F1A80 File Offset: 0x000EFC80
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x00016223 File Offset: 0x00014423
		public unsafe List<string> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0;

		// Token: 0x020008DA RID: 2266
		public class Charge : Object
		{
			// Token: 0x0600C44F RID: 50255 RVA: 0x002FD284 File Offset: 0x002FB484
			// Note: this type is marked as 'beforefieldinit'.
			static Charge()
			{
				Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Offense>.NativeClassPtr, "Charge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr);
				Offense.Charge.NativeFieldInfoPtr_chargeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "chargeName");
				Offense.Charge.NativeFieldInfoPtr_crimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "crimeIndex");
				Offense.Charge.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "quantity");
				Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, 100667906);
			}

			// Token: 0x0600C450 RID: 50256 RVA: 0x002FD300 File Offset: 0x002FB500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118861, XrefRangeEnd = 118867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Charge(string _chargeName, int _crimeIndex, int _quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_chargeName);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _crimeIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C451 RID: 50257 RVA: 0x0005F888 File Offset: 0x0005DA88
			public Charge(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D43 RID: 15683
			// (get) Token: 0x0600C452 RID: 50258 RVA: 0x002FD368 File Offset: 0x002FB568
			// (set) Token: 0x0600C453 RID: 50259 RVA: 0x0005F891 File Offset: 0x0005DA91
			public unsafe string chargeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D44 RID: 15684
			// (get) Token: 0x0600C454 RID: 50260 RVA: 0x002FD390 File Offset: 0x002FB590
			// (set) Token: 0x0600C455 RID: 50261 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
			public unsafe int crimeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex)) = value;
				}
			}

			// Token: 0x17003D45 RID: 15685
			// (get) Token: 0x0600C456 RID: 50262 RVA: 0x002FD3B8 File Offset: 0x002FB5B8
			// (set) Token: 0x0600C457 RID: 50263 RVA: 0x0005F8CB File Offset: 0x0005DACB
			public unsafe int quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x04008506 RID: 34054
			private static readonly IntPtr NativeFieldInfoPtr_chargeName;

			// Token: 0x04008507 RID: 34055
			private static readonly IntPtr NativeFieldInfoPtr_crimeIndex;

			// Token: 0x04008508 RID: 34056
			private static readonly IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x04008509 RID: 34057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}
	}
}
