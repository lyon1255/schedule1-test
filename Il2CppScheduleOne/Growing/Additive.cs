using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000557 RID: 1367
	public class Additive : MonoBehaviour
	{
		// Token: 0x06007849 RID: 30793 RVA: 0x00208604 File Offset: 0x00206804
		// Note: this type is marked as 'beforefieldinit'.
		static Additive()
		{
			Il2CppClassPointerStore<Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Additive>.NativeClassPtr);
			Additive.NativeFieldInfoPtr_AdditiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AdditiveName");
			Additive.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AssetPath");
			Additive.NativeFieldInfoPtr_QualityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "QualityChange");
			Additive.NativeFieldInfoPtr_YieldChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "YieldChange");
			Additive.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "GrowSpeedMultiplier");
			Additive.NativeFieldInfoPtr_InstantGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "InstantGrowth");
			Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Additive>.NativeClassPtr, 100678405);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x002086C0 File Offset: 0x002068C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232249, XrefRangeEnd = 232254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Additive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00039098 File Offset: 0x00037298
		public Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x002086FC File Offset: 0x002068FC
		// (set) Token: 0x0600784D RID: 30797 RVA: 0x000390A1 File Offset: 0x000372A1
		public unsafe string AdditiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x00208724 File Offset: 0x00206924
		// (set) Token: 0x0600784F RID: 30799 RVA: 0x000390C0 File Offset: 0x000372C0
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x0020874C File Offset: 0x0020694C
		// (set) Token: 0x06007851 RID: 30801 RVA: 0x000390DF File Offset: 0x000372DF
		public unsafe float QualityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange)) = value;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x00208774 File Offset: 0x00206974
		// (set) Token: 0x06007853 RID: 30803 RVA: 0x000390FA File Offset: 0x000372FA
		public unsafe float YieldChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange)) = value;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x0020879C File Offset: 0x0020699C
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x00039115 File Offset: 0x00037315
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x002087C4 File Offset: 0x002069C4
		// (set) Token: 0x06007857 RID: 30807 RVA: 0x00039130 File Offset: 0x00037330
		public unsafe float InstantGrowth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth)) = value;
			}
		}

		// Token: 0x040051FA RID: 20986
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveName;

		// Token: 0x040051FB RID: 20987
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x040051FC RID: 20988
		private static readonly IntPtr NativeFieldInfoPtr_QualityChange;

		// Token: 0x040051FD RID: 20989
		private static readonly IntPtr NativeFieldInfoPtr_YieldChange;

		// Token: 0x040051FE RID: 20990
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x040051FF RID: 20991
		private static readonly IntPtr NativeFieldInfoPtr_InstantGrowth;

		// Token: 0x04005200 RID: 20992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
