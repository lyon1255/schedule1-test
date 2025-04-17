using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000130 RID: 304
	public class WeatherEnclosure : MonoBehaviour
	{
		// Token: 0x060019F4 RID: 6644 RVA: 0x000C1ADC File Offset: 0x000BFCDC
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherEnclosure()
		{
			Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherEnclosure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr);
			WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, "nearTextureTiling");
			WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, "farTextureTiling");
			WeatherEnclosure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr, 100666054);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000C1B48 File Offset: 0x000BFD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96835, XrefRangeEnd = 96840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherEnclosure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherEnclosure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherEnclosure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public WeatherEnclosure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x000C1B84 File Offset: 0x000BFD84
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x0000EC45 File Offset: 0x0000CE45
		public unsafe Vector2 nearTextureTiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_nearTextureTiling)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x000C1BAC File Offset: 0x000BFDAC
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0000EC60 File Offset: 0x0000CE60
		public unsafe Vector2 farTextureTiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherEnclosure.NativeFieldInfoPtr_farTextureTiling)) = value;
			}
		}

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_nearTextureTiling;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_farTextureTiling;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
