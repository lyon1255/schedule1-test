using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000775 RID: 1909
	public class Dealership : MonoBehaviour
	{
		// Token: 0x0600B516 RID: 46358 RVA: 0x002D0CAC File Offset: 0x002CEEAC
		// Note: this type is marked as 'beforefieldinit'.
		static Dealership()
		{
			Il2CppClassPointerStore<Dealership>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Dealership");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealership>.NativeClassPtr);
			Dealership.NativeFieldInfoPtr_SpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealership>.NativeClassPtr, "SpawnPoints");
			Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100685573);
			Dealership.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100685574);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x002D0D18 File Offset: 0x002CEF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309806, XrefRangeEnd = 309814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x002D0D5C File Offset: 0x002CEF5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealership() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealership>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x00058D6A File Offset: 0x00056F6A
		public Dealership(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600B51A RID: 46362 RVA: 0x002D0D98 File Offset: 0x002CEF98
		// (set) Token: 0x0600B51B RID: 46363 RVA: 0x00058D73 File Offset: 0x00056F73
		public unsafe Il2CppReferenceArray<Transform> SpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A0B RID: 31243
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoints;

		// Token: 0x04007A0C RID: 31244
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0;

		// Token: 0x04007A0D RID: 31245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
