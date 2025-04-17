using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B9 RID: 953
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x06004A40 RID: 19008 RVA: 0x001685E8 File Offset: 0x001667E8
		// Note: this type is marked as 'beforefieldinit'.
		static UsableLightSource()
		{
			Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "UsableLightSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr);
			UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "GrowSpeedMultiplier");
			UsableLightSource.NativeFieldInfoPtr_isEmitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "isEmitting");
			UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, 100672505);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00168654 File Offset: 0x00166854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163826, XrefRangeEnd = 163827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsableLightSource() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00023CF4 File Offset: 0x00021EF4
		public UsableLightSource(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x00168690 File Offset: 0x00166890
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x00023CFD File Offset: 0x00021EFD
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x001686B8 File Offset: 0x001668B8
		// (set) Token: 0x06004A46 RID: 19014 RVA: 0x00023D18 File Offset: 0x00021F18
		public unsafe bool isEmitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting)) = value;
			}
		}

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeFieldInfoPtr_isEmitting;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
