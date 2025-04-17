using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000599 RID: 1433
	[Serializable]
	public class DrugTypeContainer : Object
	{
		// Token: 0x06007DDD RID: 32221 RVA: 0x0021B1D4 File Offset: 0x002193D4
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeContainer()
		{
			Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr);
			DrugTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, "DrugType");
			DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, 100679037);
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x0021B22C File Offset: 0x0021942C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x0003BD33 File Offset: 0x00039F33
		public DrugTypeContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06007DE0 RID: 32224 RVA: 0x0021B268 File Offset: 0x00219468
		// (set) Token: 0x06007DE1 RID: 32225 RVA: 0x0003BD3C File Offset: 0x00039F3C
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x04005597 RID: 21911
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04005598 RID: 21912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
