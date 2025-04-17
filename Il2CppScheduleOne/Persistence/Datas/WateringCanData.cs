using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026D RID: 621
	[Serializable]
	public class WateringCanData : ItemData
	{
		// Token: 0x06002F51 RID: 12113 RVA: 0x00107488 File Offset: 0x00105688
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanData()
		{
			Il2CppClassPointerStore<WateringCanData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WateringCanData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr);
			WateringCanData.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, "CurrentFillAmount");
			WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr, 100668768);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x001074E0 File Offset: 0x001056E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130588, RefRangeEnd = 130590, XrefRangeStart = 130588, XrefRangeEnd = 130590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanData(string iD, int quantity, float currentFillLevel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x0001909A File Offset: 0x0001729A
		public WateringCanData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x00107548 File Offset: 0x00105748
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x000190A3 File Offset: 0x000172A3
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanData.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
