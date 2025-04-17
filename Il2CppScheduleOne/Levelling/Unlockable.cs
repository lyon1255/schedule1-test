using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BE RID: 958
	public class Unlockable : Il2CppSystem.Object
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x0016A584 File Offset: 0x00168784
		// Note: this type is marked as 'beforefieldinit'.
		static Unlockable()
		{
			Il2CppClassPointerStore<Unlockable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "Unlockable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unlockable>.NativeClassPtr);
			Unlockable.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Rank");
			Unlockable.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Title");
			Unlockable.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Icon");
			Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, 100672579);
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x0016A604 File Offset: 0x00168804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164435, RefRangeEnd = 164437, XrefRangeStart = 164432, XrefRangeEnd = 164435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unlockable(FullRank rank, string title, Sprite icon) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unlockable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00023FA6 File Offset: 0x000221A6
		public Unlockable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x0016A670 File Offset: 0x00168870
		// (set) Token: 0x06004AC4 RID: 19140 RVA: 0x00023FAF File Offset: 0x000221AF
		public unsafe FullRank Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x0016A698 File Offset: 0x00168898
		// (set) Token: 0x06004AC6 RID: 19142 RVA: 0x00023FCA File Offset: 0x000221CA
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x0016A6C0 File Offset: 0x001688C0
		// (set) Token: 0x06004AC8 RID: 19144 RVA: 0x00023FE9 File Offset: 0x000221E9
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0;
	}
}
