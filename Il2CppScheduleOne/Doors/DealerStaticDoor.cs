using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000420 RID: 1056
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x06005CF3 RID: 23795 RVA: 0x001ADA80 File Offset: 0x001ABC80
		// Note: this type is marked as 'beforefieldinit'.
		static DealerStaticDoor()
		{
			Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DealerStaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr);
			DealerStaticDoor.NativeFieldInfoPtr_Dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, "Dealer");
			DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675147);
			DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675148);
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x001ADAEC File Offset: 0x001ABCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195571, XrefRangeEnd = 195585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x001ADB50 File Offset: 0x001ABD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195585, XrefRangeEnd = 195586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerStaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x0002BCC8 File Offset: 0x00029EC8
		public DealerStaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x001ADB8C File Offset: 0x001ABD8C
		// (set) Token: 0x06005CF8 RID: 23800 RVA: 0x0002BCD1 File Offset: 0x00029ED1
		public unsafe Dealer Dealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F98 RID: 16280
		private static readonly IntPtr NativeFieldInfoPtr_Dealer;

		// Token: 0x04003F99 RID: 16281
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0;

		// Token: 0x04003F9A RID: 16282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
