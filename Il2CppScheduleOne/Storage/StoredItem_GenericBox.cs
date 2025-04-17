using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000580 RID: 1408
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x06007BF1 RID: 31729 RVA: 0x00215400 File Offset: 0x00213600
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_GenericBox()
		{
			Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem_GenericBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr);
			StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "ReferenceIconWidth");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon1");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon2");
			StoredItem_GenericBox.NativeFieldInfoPtr_IconScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "IconScale");
			StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678839);
			StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678840);
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x002154A8 File Offset: 0x002136A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236977, XrefRangeEnd = 236985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x00215524 File Offset: 0x00213724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236985, XrefRangeEnd = 236986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_GenericBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x0003ACED File Offset: 0x00038EED
		public StoredItem_GenericBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x00215560 File Offset: 0x00213760
		// (set) Token: 0x06007BF6 RID: 31734 RVA: 0x0003ACF6 File Offset: 0x00038EF6
		public unsafe static float ReferenceIconWidth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&value));
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06007BF7 RID: 31735 RVA: 0x0021557C File Offset: 0x0021377C
		// (set) Token: 0x06007BF8 RID: 31736 RVA: 0x0003AD04 File Offset: 0x00038F04
		public unsafe SpriteRenderer icon1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x002155AC File Offset: 0x002137AC
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x0003AD23 File Offset: 0x00038F23
		public unsafe SpriteRenderer icon2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x002155DC File Offset: 0x002137DC
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x0003AD42 File Offset: 0x00038F42
		public unsafe float IconScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale)) = value;
			}
		}

		// Token: 0x04005467 RID: 21607
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceIconWidth;

		// Token: 0x04005468 RID: 21608
		private static readonly IntPtr NativeFieldInfoPtr_icon1;

		// Token: 0x04005469 RID: 21609
		private static readonly IntPtr NativeFieldInfoPtr_icon2;

		// Token: 0x0400546A RID: 21610
		private static readonly IntPtr NativeFieldInfoPtr_IconScale;

		// Token: 0x0400546B RID: 21611
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400546C RID: 21612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
