using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073C RID: 1852
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x0600AAE6 RID: 43750 RVA: 0x002AAFA0 File Offset: 0x002A91A0
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronDisplayTub()
		{
			Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CauldronDisplayTub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr);
			CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "CocaLeafContainer");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Min");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Max");
			CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684284);
			CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684285);
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x002AB034 File Offset: 0x002A9234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296826, RefRangeEnd = 296828, XrefRangeStart = 296813, XrefRangeEnd = 296826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref contentsType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x002AB080 File Offset: 0x002A9280
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronDisplayTub() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x000540C1 File Offset: 0x000522C1
		public CauldronDisplayTub(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600AAEA RID: 43754 RVA: 0x002AB0BC File Offset: 0x002A92BC
		// (set) Token: 0x0600AAEB RID: 43755 RVA: 0x000540CA File Offset: 0x000522CA
		public unsafe Transform CocaLeafContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600AAEC RID: 43756 RVA: 0x002AB0EC File Offset: 0x002A92EC
		// (set) Token: 0x0600AAED RID: 43757 RVA: 0x000540E9 File Offset: 0x000522E9
		public unsafe Transform Container_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600AAEE RID: 43758 RVA: 0x002AB11C File Offset: 0x002A931C
		// (set) Token: 0x0600AAEF RID: 43759 RVA: 0x00054108 File Offset: 0x00052308
		public unsafe Transform Container_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072D9 RID: 29401
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeafContainer;

		// Token: 0x040072DA RID: 29402
		private static readonly IntPtr NativeFieldInfoPtr_Container_Min;

		// Token: 0x040072DB RID: 29403
		private static readonly IntPtr NativeFieldInfoPtr_Container_Max;

		// Token: 0x040072DC RID: 29404
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0;

		// Token: 0x040072DD RID: 29405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE5 RID: 3045
		[OriginalName("Assembly-CSharp.dll", "", "EContents")]
		public enum EContents
		{
			// Token: 0x04009557 RID: 38231
			None,
			// Token: 0x04009558 RID: 38232
			CocaLeaf
		}
	}
}
