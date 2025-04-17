using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000616 RID: 1558
	[Serializable]
	public class BasicAvatarSettings : ScriptableObject
	{
		// Token: 0x06008985 RID: 35205 RVA: 0x00241CF4 File Offset: 0x0023FEF4
		// Note: this type is marked as 'beforefieldinit'.
		static BasicAvatarSettings()
		{
			Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "BasicAvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr);
			BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "GENDER_MULTIPLIER");
			BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "MaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FemaleUnderwearPath");
			BasicAvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Gender");
			BasicAvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Weight");
			BasicAvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "SkinColor");
			BasicAvatarSettings.NativeFieldInfoPtr_HairStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairStyle");
			BasicAvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HairColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Mouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Mouth");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialHair");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetails");
			BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "FacialDetailsIntensity");
			BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyeballColor");
			BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "UpperEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "LowerEyeLidRestingPosition");
			BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "PupilDilation");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowScale");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowThickness");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			BasicAvatarSettings.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Top");
			BasicAvatarSettings.NativeFieldInfoPtr_TopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "TopColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Bottom");
			BasicAvatarSettings.NativeFieldInfoPtr_BottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "BottomColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Shoes");
			BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "ShoesColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Headwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Headwear");
			BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "HeadwearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Eyewear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Eyewear");
			BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "EyewearColor");
			BasicAvatarSettings.NativeFieldInfoPtr_Tattoos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, "Tattoos");
			BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680415);
			BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680416);
			BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680417);
			BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680418);
			BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr, 100680419);
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x00241FF4 File Offset: 0x002401F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253346, XrefRangeEnd = 253351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x0024209C File Offset: 0x0024029C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253357, RefRangeEnd = 253358, XrefRangeStart = 253351, XrefRangeEnd = 253357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x002420E8 File Offset: 0x002402E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 253460, RefRangeEnd = 253471, XrefRangeStart = 253358, XrefRangeEnd = 253460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings GetAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x00242128 File Offset: 0x00240328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicAvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x00242178 File Offset: 0x00240378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253471, XrefRangeEnd = 253479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicAvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicAvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x00041AAA File Offset: 0x0003FCAA
		public BasicAvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600898C RID: 35212 RVA: 0x002421B4 File Offset: 0x002403B4
		// (set) Token: 0x0600898D RID: 35213 RVA: 0x00041AB3 File Offset: 0x0003FCB3
		public unsafe static float GENDER_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_GENDER_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x002421D0 File Offset: 0x002403D0
		// (set) Token: 0x0600898F RID: 35215 RVA: 0x00041AC1 File Offset: 0x0003FCC1
		public unsafe static string MaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_MaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x002421F0 File Offset: 0x002403F0
		// (set) Token: 0x06008991 RID: 35217 RVA: 0x00041AD3 File Offset: 0x0003FCD3
		public unsafe static string FemaleUnderwearPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BasicAvatarSettings.NativeFieldInfoPtr_FemaleUnderwearPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x00242210 File Offset: 0x00240410
		// (set) Token: 0x06008993 RID: 35219 RVA: 0x00041AE5 File Offset: 0x0003FCE5
		public unsafe int Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x00242238 File Offset: 0x00240438
		// (set) Token: 0x06008995 RID: 35221 RVA: 0x00041B00 File Offset: 0x0003FD00
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x00242260 File Offset: 0x00240460
		// (set) Token: 0x06008997 RID: 35223 RVA: 0x00041B1B File Offset: 0x0003FD1B
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x00242288 File Offset: 0x00240488
		// (set) Token: 0x06008999 RID: 35225 RVA: 0x00041B36 File Offset: 0x0003FD36
		public unsafe string HairStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairStyle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600899A RID: 35226 RVA: 0x002422B0 File Offset: 0x002404B0
		// (set) Token: 0x0600899B RID: 35227 RVA: 0x00041B55 File Offset: 0x0003FD55
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x002422D8 File Offset: 0x002404D8
		// (set) Token: 0x0600899D RID: 35229 RVA: 0x00041B70 File Offset: 0x0003FD70
		public unsafe string Mouth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Mouth), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600899E RID: 35230 RVA: 0x00242300 File Offset: 0x00240500
		// (set) Token: 0x0600899F RID: 35231 RVA: 0x00041B8F File Offset: 0x0003FD8F
		public unsafe string FacialHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialHair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x060089A0 RID: 35232 RVA: 0x00242328 File Offset: 0x00240528
		// (set) Token: 0x060089A1 RID: 35233 RVA: 0x00041BAE File Offset: 0x0003FDAE
		public unsafe string FacialDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetails), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x060089A2 RID: 35234 RVA: 0x00242350 File Offset: 0x00240550
		// (set) Token: 0x060089A3 RID: 35235 RVA: 0x00041BCD File Offset: 0x0003FDCD
		public unsafe float FacialDetailsIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_FacialDetailsIntensity)) = value;
			}
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x060089A4 RID: 35236 RVA: 0x00242378 File Offset: 0x00240578
		// (set) Token: 0x060089A5 RID: 35237 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		public unsafe Color EyeballColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyeballColor)) = value;
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x002423A0 File Offset: 0x002405A0
		// (set) Token: 0x060089A7 RID: 35239 RVA: 0x00041C03 File Offset: 0x0003FE03
		public unsafe float UpperEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_UpperEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x060089A8 RID: 35240 RVA: 0x002423C8 File Offset: 0x002405C8
		// (set) Token: 0x060089A9 RID: 35241 RVA: 0x00041C1E File Offset: 0x0003FE1E
		public unsafe float LowerEyeLidRestingPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_LowerEyeLidRestingPosition)) = value;
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x060089AA RID: 35242 RVA: 0x002423F0 File Offset: 0x002405F0
		// (set) Token: 0x060089AB RID: 35243 RVA: 0x00041C39 File Offset: 0x0003FE39
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x00242418 File Offset: 0x00240618
		// (set) Token: 0x060089AD RID: 35245 RVA: 0x00041C54 File Offset: 0x0003FE54
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x00242440 File Offset: 0x00240640
		// (set) Token: 0x060089AF RID: 35247 RVA: 0x00041C6F File Offset: 0x0003FE6F
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x060089B0 RID: 35248 RVA: 0x00242468 File Offset: 0x00240668
		// (set) Token: 0x060089B1 RID: 35249 RVA: 0x00041C8A File Offset: 0x0003FE8A
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x00242490 File Offset: 0x00240690
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x00041CA5 File Offset: 0x0003FEA5
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x002424B8 File Offset: 0x002406B8
		// (set) Token: 0x060089B5 RID: 35253 RVA: 0x00041CC0 File Offset: 0x0003FEC0
		public unsafe string Top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Top), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x060089B6 RID: 35254 RVA: 0x002424E0 File Offset: 0x002406E0
		// (set) Token: 0x060089B7 RID: 35255 RVA: 0x00041CDF File Offset: 0x0003FEDF
		public unsafe Color TopColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_TopColor)) = value;
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x060089B8 RID: 35256 RVA: 0x00242508 File Offset: 0x00240708
		// (set) Token: 0x060089B9 RID: 35257 RVA: 0x00041CFA File Offset: 0x0003FEFA
		public unsafe string Bottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Bottom), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x060089BA RID: 35258 RVA: 0x00242530 File Offset: 0x00240730
		// (set) Token: 0x060089BB RID: 35259 RVA: 0x00041D19 File Offset: 0x0003FF19
		public unsafe Color BottomColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_BottomColor)) = value;
			}
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x00242558 File Offset: 0x00240758
		// (set) Token: 0x060089BD RID: 35261 RVA: 0x00041D34 File Offset: 0x0003FF34
		public unsafe string Shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Shoes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x060089BE RID: 35262 RVA: 0x00242580 File Offset: 0x00240780
		// (set) Token: 0x060089BF RID: 35263 RVA: 0x00041D53 File Offset: 0x0003FF53
		public unsafe Color ShoesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_ShoesColor)) = value;
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x002425A8 File Offset: 0x002407A8
		// (set) Token: 0x060089C1 RID: 35265 RVA: 0x00041D6E File Offset: 0x0003FF6E
		public unsafe string Headwear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Headwear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x002425D0 File Offset: 0x002407D0
		// (set) Token: 0x060089C3 RID: 35267 RVA: 0x00041D8D File Offset: 0x0003FF8D
		public unsafe Color HeadwearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_HeadwearColor)) = value;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x002425F8 File Offset: 0x002407F8
		// (set) Token: 0x060089C5 RID: 35269 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		public unsafe string Eyewear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Eyewear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x060089C6 RID: 35270 RVA: 0x00242620 File Offset: 0x00240820
		// (set) Token: 0x060089C7 RID: 35271 RVA: 0x00041DC7 File Offset: 0x0003FFC7
		public unsafe Color EyewearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_EyewearColor)) = value;
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x060089C8 RID: 35272 RVA: 0x00242648 File Offset: 0x00240848
		// (set) Token: 0x060089C9 RID: 35273 RVA: 0x00041DE2 File Offset: 0x0003FFE2
		public unsafe List<string> Tattoos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicAvatarSettings.NativeFieldInfoPtr_Tattoos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D5E RID: 23902
		private static readonly IntPtr NativeFieldInfoPtr_GENDER_MULTIPLIER;

		// Token: 0x04005D5F RID: 23903
		private static readonly IntPtr NativeFieldInfoPtr_MaleUnderwearPath;

		// Token: 0x04005D60 RID: 23904
		private static readonly IntPtr NativeFieldInfoPtr_FemaleUnderwearPath;

		// Token: 0x04005D61 RID: 23905
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x04005D62 RID: 23906
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x04005D63 RID: 23907
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x04005D64 RID: 23908
		private static readonly IntPtr NativeFieldInfoPtr_HairStyle;

		// Token: 0x04005D65 RID: 23909
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x04005D66 RID: 23910
		private static readonly IntPtr NativeFieldInfoPtr_Mouth;

		// Token: 0x04005D67 RID: 23911
		private static readonly IntPtr NativeFieldInfoPtr_FacialHair;

		// Token: 0x04005D68 RID: 23912
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetails;

		// Token: 0x04005D69 RID: 23913
		private static readonly IntPtr NativeFieldInfoPtr_FacialDetailsIntensity;

		// Token: 0x04005D6A RID: 23914
		private static readonly IntPtr NativeFieldInfoPtr_EyeballColor;

		// Token: 0x04005D6B RID: 23915
		private static readonly IntPtr NativeFieldInfoPtr_UpperEyeLidRestingPosition;

		// Token: 0x04005D6C RID: 23916
		private static readonly IntPtr NativeFieldInfoPtr_LowerEyeLidRestingPosition;

		// Token: 0x04005D6D RID: 23917
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005D6E RID: 23918
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x04005D6F RID: 23919
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x04005D70 RID: 23920
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x04005D71 RID: 23921
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x04005D72 RID: 23922
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04005D73 RID: 23923
		private static readonly IntPtr NativeFieldInfoPtr_TopColor;

		// Token: 0x04005D74 RID: 23924
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04005D75 RID: 23925
		private static readonly IntPtr NativeFieldInfoPtr_BottomColor;

		// Token: 0x04005D76 RID: 23926
		private static readonly IntPtr NativeFieldInfoPtr_Shoes;

		// Token: 0x04005D77 RID: 23927
		private static readonly IntPtr NativeFieldInfoPtr_ShoesColor;

		// Token: 0x04005D78 RID: 23928
		private static readonly IntPtr NativeFieldInfoPtr_Headwear;

		// Token: 0x04005D79 RID: 23929
		private static readonly IntPtr NativeFieldInfoPtr_HeadwearColor;

		// Token: 0x04005D7A RID: 23930
		private static readonly IntPtr NativeFieldInfoPtr_Eyewear;

		// Token: 0x04005D7B RID: 23931
		private static readonly IntPtr NativeFieldInfoPtr_EyewearColor;

		// Token: 0x04005D7C RID: 23932
		private static readonly IntPtr NativeFieldInfoPtr_Tattoos;

		// Token: 0x04005D7D RID: 23933
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_0;

		// Token: 0x04005D7E RID: 23934
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x04005D7F RID: 23935
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatarSettings_Public_AvatarSettings_0;

		// Token: 0x04005D80 RID: 23936
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04005D81 RID: 23937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B09 RID: 2825
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_0<T>
		{
			// Token: 0x04009035 RID: 36917
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_SetValue_Public_T_String_T_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B0A RID: 2826
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x04009036 RID: 36918
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BasicAvatarSettings.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<BasicAvatarSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
