using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000588 RID: 1416
	public class IngredientModule : ItemModule
	{
		// Token: 0x06007CAF RID: 31919 RVA: 0x00217898 File Offset: 0x00215A98
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientModule()
		{
			Il2CppClassPointerStore<IngredientModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr);
			IngredientModule.NativeFieldInfoPtr_Pieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, "Pieces");
			IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678919);
			IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678920);
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x00217904 File Offset: 0x00215B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237378, XrefRangeEnd = 237386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x00217954 File Offset: 0x00215B54
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x0003B308 File Offset: 0x00039508
		public IngredientModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x00217990 File Offset: 0x00215B90
		// (set) Token: 0x06007CB4 RID: 31924 RVA: 0x0003B311 File Offset: 0x00039511
		public unsafe Il2CppReferenceArray<IngredientPiece> Pieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054E0 RID: 21728
		private static readonly IntPtr NativeFieldInfoPtr_Pieces;

		// Token: 0x040054E1 RID: 21729
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x040054E2 RID: 21730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
