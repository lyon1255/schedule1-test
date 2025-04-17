using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DA RID: 1498
	public class ItemFilter_LegalStatus : ItemFilter
	{
		// Token: 0x06008351 RID: 33617 RVA: 0x0022E7E4 File Offset: 0x0022C9E4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_LegalStatus()
		{
			Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_LegalStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr);
			ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, "RequiredLegalStatus");
			ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100679721);
			ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr, 100679722);
		}

		// Token: 0x06008352 RID: 33618 RVA: 0x0022E850 File Offset: 0x0022CA50
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_LegalStatus>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requiredLegalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_LegalStatus.NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x0022E898 File Offset: 0x0022CA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247037, XrefRangeEnd = 247038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_LegalStatus.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0003E629 File Offset: 0x0003C829
		public ItemFilter_LegalStatus(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x0022E8F0 File Offset: 0x0022CAF0
		// (set) Token: 0x06008356 RID: 33622 RVA: 0x0003E632 File Offset: 0x0003C832
		public unsafe ELegalStatus RequiredLegalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_LegalStatus.NativeFieldInfoPtr_RequiredLegalStatus)) = value;
			}
		}

		// Token: 0x04005961 RID: 22881
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLegalStatus;

		// Token: 0x04005962 RID: 22882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ELegalStatus_0;

		// Token: 0x04005963 RID: 22883
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
