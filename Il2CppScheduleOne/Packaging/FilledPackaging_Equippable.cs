using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000560 RID: 1376
	public class FilledPackaging_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060078D5 RID: 30933 RVA: 0x00209F50 File Offset: 0x00208150
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackaging_Equippable()
		{
			Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackaging_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr);
			FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, "Visuals");
			FilledPackaging_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678449);
			FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678450);
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x00209FBC File Offset: 0x002081BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232578, XrefRangeEnd = 232582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x0020A00C File Offset: 0x0020820C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackaging_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x000395A6 File Offset: 0x000377A6
		public FilledPackaging_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x060078D9 RID: 30937 RVA: 0x0020A048 File Offset: 0x00208248
		// (set) Token: 0x060078DA RID: 30938 RVA: 0x000395AF File Offset: 0x000377AF
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400524A RID: 21066
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400524B RID: 21067
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400524C RID: 21068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
