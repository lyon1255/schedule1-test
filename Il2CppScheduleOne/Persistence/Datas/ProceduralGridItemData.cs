using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029F RID: 671
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x060030EF RID: 12527 RVA: 0x0010BDB4 File Offset: 0x00109FB4
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItemData()
		{
			Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProceduralGridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr);
			ProceduralGridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "Rotation");
			ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "FootprintMatches");
			ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, 100668820);
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0010BE20 File Offset: 0x0010A020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130958, RefRangeEnd = 130959, XrefRangeStart = 130953, XrefRangeEnd = 130958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, Il2CppReferenceArray<FootprintMatchData> footprintMatches) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(footprintMatches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0001A1B2 File Offset: 0x000183B2
		public ProceduralGridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0010BEA8 File Offset: 0x0010A0A8
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x0001A1BB File Offset: 0x000183BB
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x0010BED0 File Offset: 0x0010A0D0
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x0001A1D6 File Offset: 0x000183D6
		public unsafe Il2CppReferenceArray<FootprintMatchData> FootprintMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FootprintMatchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeFieldInfoPtr_FootprintMatches;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0;
	}
}
