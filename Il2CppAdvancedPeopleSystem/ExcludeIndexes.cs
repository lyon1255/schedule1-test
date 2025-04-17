using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000150 RID: 336
	[Serializable]
	public class ExcludeIndexes : Object
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x000C6C50 File Offset: 0x000C4E50
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeIndexes()
		{
			Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "ExcludeIndexes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr);
			ExcludeIndexes.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, "item");
			ExcludeIndexes.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, "index");
			ExcludeIndexes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr, 100666230);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000C6CBC File Offset: 0x000C4EBC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeIndexes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeIndexes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeIndexes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0000FA63 File Offset: 0x0000DC63
		public ExcludeIndexes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000C6CF8 File Offset: 0x000C4EF8
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		public unsafe ExcludeItem item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_item);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_item)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000C6D20 File Offset: 0x000C4F20
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000FA87 File Offset: 0x0000DC87
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExcludeIndexes.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
